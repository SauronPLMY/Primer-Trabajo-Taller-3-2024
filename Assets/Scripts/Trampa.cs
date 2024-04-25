using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject prefabExplosion;
    public Transform posicionExplosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            print("lava!");
            //collision.transform.position = CheckPointSystem.instance.UltimaPos;
            Vector3 pos = collision.transform.position + Vector3.up;
            Instantiate(prefabExplosion, pos, Quaternion.identity);
            collision.gameObject.SetActive(false);
        }
    }
}
