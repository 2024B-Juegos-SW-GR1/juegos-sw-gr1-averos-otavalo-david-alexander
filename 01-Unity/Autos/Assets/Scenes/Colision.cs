using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("AUUCH");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando al trigger con:" + other.tag + "con el nombre de objeto:" + other.name);
        if (other.CompareTag("Damage") && hasPackage != true)
        {
            Debug.Log("-1000 aura");
            hasPackage = false;
            _spriteRenderer.color = Color.green;
        }

        if (other.CompareTag("paquete"))
        {
            Debug.Log("Paquete recogido");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
    }
}
