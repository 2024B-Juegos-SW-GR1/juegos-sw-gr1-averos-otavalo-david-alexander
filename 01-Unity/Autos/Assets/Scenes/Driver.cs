using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        float steerArmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveArmount = Input.GetAxis("Vertical") * moveSpeed;
        
        transform.Rotate(0, 0, steerArmount);
        transform.Translate(0,moveArmount,0);
    }
}
