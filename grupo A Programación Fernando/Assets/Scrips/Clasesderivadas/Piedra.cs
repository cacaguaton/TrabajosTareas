using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedra : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        Da�oAtaque = 6;
        Durabilidad = 132;
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
