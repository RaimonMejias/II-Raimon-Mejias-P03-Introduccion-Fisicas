using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej12 : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            Vector3 movement = (Input.GetKey(KeyCode.LeftArrow)? Vector3.left : Vector3.right);
            GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime, ForceMode.Impulse);
        }
       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
            Vector3 movement = (Input.GetKey(KeyCode.UpArrow)? Vector3.forward : Vector3.back);
            GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime , ForceMode.Impulse);
        }
    }
}
