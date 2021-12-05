 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    [SerializeField] private float startingTime;
    [SerializeField] public Text countdownText;

    public void Start()
    {
        currentTime = startingTime;
    }
    public void Update()
    {
        currentTime -=Time.deltaTime;
        countdownText.text = "Tiempo: " + currentTime.ToString("0");

    }

}
