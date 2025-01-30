using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntaje : MonoBehaviour
{
    private int puntajes = 0;

    private void OnCollisionEnter(Collision other)
    {
        puntajes++;
        Debug.Log("Jugardor tiene: "+puntajes);
    }
}
