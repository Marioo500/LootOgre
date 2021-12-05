using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slide;
    public void  setMaximo(int max)
    {
        slide.maxValue = max;
        slide.value = max;
    }
    public void setVida(int vida)
    {
        slide.value = vida;
    }
}
