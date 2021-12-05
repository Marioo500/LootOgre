using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] public List<Pregunta> lista_Preguntas; 
    private List<Pregunta> backup;
    public void Awake()
    {
        backup = lista_Preguntas;
    }

    public void realizarBackup()
    {
        lista_Preguntas = backup;
    }
}

