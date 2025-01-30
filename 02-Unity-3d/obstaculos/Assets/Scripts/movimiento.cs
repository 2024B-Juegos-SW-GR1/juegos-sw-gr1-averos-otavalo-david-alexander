using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField] private float velocidad = 0f;
    [SerializeField] private float xValue = 0f;
    [SerializeField] private float yValue = 0.05f;
    [SerializeField] private float zValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        imprimirInstrucciones();
    }

    void imprimirInstrucciones()
    {
        Debug.Log("Bienvenido del movimiento");
        Debug.Log("Muevete usando WASD");
        Debug.Log("Velocidad: " + velocidad);
    }

    void moverJugador()
    {
        float movientoX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        float movientoY = 0f;
        float movientoZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
        transform.Translate(movientoX, movientoY, movientoZ);
    }
    // Update is called once per frame
    void Update()
    {
        moverJugador();
    }
}
