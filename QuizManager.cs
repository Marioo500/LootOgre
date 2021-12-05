using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private QuizUI qUI;
    [SerializeField] private QuizDB db;
    private int score = 0;
    private Pregunta p_seleccionada;
    void Start()
    {
        db = GameObject.FindObjectOfType<QuizDB>();
        selectPregunta();
        score = 0;

    }

    public bool Answer(string posibleRespuesta)
    {
        bool correct = false;
        if(posibleRespuesta == p_seleccionada.respuesta)
        {
            correct = true;
            score += 10;
            qUI.ScoreText.text = "Score: " + score;
        }
        else
        {

        }
        Invoke("selectPregunta", 0.5f);
        return correct;

    }

    public void selectPregunta()
    {
        int index = UnityEngine.Random.Range(0,db.lista_Preguntas.Count);
        p_seleccionada = db.lista_Preguntas[index];
        db.lista_Preguntas.RemoveAt(index);
        if(db.lista_Preguntas.Count == 0)
        {
            db.realizarBackup();
        }
        qUI.setPregunta(p_seleccionada);
    }

}
