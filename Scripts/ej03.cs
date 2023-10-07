using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej03 : MonoBehaviour
{
    
    public Vector3 moveDirection = new Vector3(0, 0, 0);
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position - new Vector3(0, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
