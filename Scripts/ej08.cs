using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej08 : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // TERMINAR ESTE EJERCICIO 
    // Update is called once per frame
    void Update()
    {
        float movement = speed * Time.deltaTime;
        transform.Rotate(transform.up * Input.GetAxis("Horizontal"), Space.World);
        transform.Translate(transform.forward * movement, Space.World);
        Debug.DrawRay(transform.position, transform.forward * 2 , Color.red);
    }
}
