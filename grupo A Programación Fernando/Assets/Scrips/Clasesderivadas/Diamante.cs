using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        DañoAtaque = 8;
        Durabilidad = 1562;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.CompareTag("Enemigo"))
        //{
        //    DañoTotal = VidaEnemigo - DañoAtaque;
        //    Debug.Log("Derribando enemigo!");
        //}
    }
}
