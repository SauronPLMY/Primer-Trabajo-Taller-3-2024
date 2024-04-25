using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{

    public TextMeshProUGUI contadorText;
    void Start()
    {

    }

    public float tiempo = 0;
    public float intervalo = 5f;
    public float tiempoTotal = 10f;
    bool seDetiene = true;
    public float tiempo2 = 0;


    void Update()
    {
        tiempo += Time.deltaTime;
        tiempo2 += Time.deltaTime;

     

        contadorText.text =  tiempo.ToString("Time: " + "0 " + "Seg");

    }
}