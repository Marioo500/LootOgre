using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Timer cronometro;
    [SerializeField] private Text preguntaTexto, scoreText;
    [SerializeField] private GameObject gameOverpanel, nextLevelpanel;  
    [SerializeField] private QuizManager qzM;
    [SerializeField] private List<Button> botones_opciones;
    [SerializeField] private Color color_Correcto;
    [SerializeField] private Color color_Inorrecto;
    [SerializeField] private Color color_Normal = Color.white;
    [SerializeField] public Jugador player;
    [SerializeField] public Jugador ogro;
    private Pregunta pregunta;
    private bool isCorrect;

    public Text ScoreText {get{return scoreText;}}
    public GameObject GameOverPanel {get {return gameOverpanel;}}
    public GameObject LevelSuperadoPanel {get {return nextLevelpanel;}}

    void Awake()
    {
        for(int i = 0; i< botones_opciones.Count;i++)
        {
            Button localBtn = botones_opciones[i];
            localBtn.onClick.AddListener(()=> OnClick(localBtn));
        }
    } 
    void Update()
    {
        if(cronometro.currentTime <=0)
        {
            GameOverPanel.SetActive(true);
        }
    }
    public void setPregunta(Pregunta pregunta)
    {
        cronometro.Start();
        this.pregunta = pregunta;
        preguntaTexto.text = pregunta.pregunta;
        List<string> answerList = pregunta.opciones;
        for (int i = 0; i < answerList.Count; i++) {
            string temp = answerList[i];
            int randomIndex = UnityEngine.Random.Range(i, answerList.Count);
            answerList[i] = answerList[randomIndex];
            answerList[randomIndex] = temp;
     }        
        for(int i=0;i <botones_opciones.Count ;i++)
        {
            botones_opciones[i].GetComponentInChildren<Text>().text = answerList[i];
            botones_opciones[i].name = answerList[i];
            botones_opciones[i].image.color = Color.white;
        }

        isCorrect = false;
    }

    public void OnClick(Button btn)
    {
        if(!isCorrect)
        {
            isCorrect = true;
            bool val = qzM.Answer(btn.name);

            if(val)
            {
                btn.image.color = color_Correcto;
                ogro.update();
                if(ogro.vida_actual == 0)
                {
                    nextLevelpanel.SetActive(true);
                }
            }
            else
            {
                btn.image.color = color_Inorrecto;
                player.update();
                if(player.vida_actual == 0)
                {
                    GameOverPanel.SetActive(true);
                }
            }
        }
    }
}
