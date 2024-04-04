using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class VidaPlayer : MonoBehaviour
{
    public int vidaInicial = 100;
    public int vidaActual;
    public Text textoVida;

    private void Start()
    {
        vidaActual = vidaInicial;
        ActualizarTextoVida();
    }

    public void RecibirDaño(int cantidadDeDaño)
    {
        vidaActual -= cantidadDeDaño;

        if (vidaActual <= 0)
        {
            Debug.Log("El jugador ha muerto");
        }

        ActualizarTextoVida();
    }

    private void ActualizarTextoVida()
    {
        if (textoVida != null)
        {
            textoVida.text = "Vida: " + vidaActual.ToString();
        }
    }
}

