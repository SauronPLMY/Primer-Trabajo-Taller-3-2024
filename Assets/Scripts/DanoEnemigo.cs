using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DanoEnemigo : MonoBehaviour
{
    public int cantidadDeDano = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            VidaPlayer vidaPlayer = collision.GetComponent<VidaPlayer>();

            if (vidaPlayer != null)
            {
                vidaPlayer.RecibirDaño(cantidadDeDano);
            }
        }
    }
}