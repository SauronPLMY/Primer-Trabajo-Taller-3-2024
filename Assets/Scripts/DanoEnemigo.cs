using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DanoEnemigo : MonoBehaviour
{
    public int cantidadDeDaño = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VidaPlayer vidaPlayer = other.GetComponent<VidaPlayer>();

            if (vidaPlayer != null)
            {
                vidaPlayer.RecibirDaño(cantidadDeDaño);
            }
        }
    }
}