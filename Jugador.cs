using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jugador : MonoBehaviour
{
    [SerializeField] private int max;
    public int vida_actual;
    public BarraVida barrita;

    public void Start()
    {
        vida_actual = max;
        barrita.setMaximo(vida_actual);

    }

    public void update()
    {
        takeDamage();   
    }

    public void takeDamage()
    {
        vida_actual = vida_actual - 10;
        barrita.setVida(vida_actual);
    }
}
