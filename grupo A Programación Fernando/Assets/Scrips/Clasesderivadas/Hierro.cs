using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hierro : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        DañoAtaque = 7;
        Durabilidad = 251;
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
