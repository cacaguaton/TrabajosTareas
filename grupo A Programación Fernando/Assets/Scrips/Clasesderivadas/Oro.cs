using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oro : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        Da�oAtaque = 5;
        Durabilidad = 30;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.CompareTag("Enemigo"))
        //{
        //    Da�oTotal = VidaEnemigo - Da�oAtaque;
        //    Debug.Log("Derribando enemigo!");
        //}
    }
}
