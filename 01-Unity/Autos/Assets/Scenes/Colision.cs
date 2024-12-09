using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("AUUCH");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando al trigger");
        if (other.tag == "Damage")
        {
            Debug.Log("-1000 aura");
        }

        if (other.tag == "Paquete")
        {
            Debug.Log("Paquete recogido");
        }
    }
}
