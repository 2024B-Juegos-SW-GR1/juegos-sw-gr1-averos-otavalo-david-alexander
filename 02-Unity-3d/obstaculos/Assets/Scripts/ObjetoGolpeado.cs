using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoGolpeado : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("Objeto Golpeado");
    }
}
