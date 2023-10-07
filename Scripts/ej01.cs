using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej01 : MonoBehaviour
{

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string key = "";
        float speedAxis = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            key = Input.GetKey(KeyCode.LeftArrow)? "LeftArrow" : "RightArrow";
            speedAxis = speed * Input.GetAxis("Horizontal");
            Debug.Log($"{key}: {speedAxis}");
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
            key = Input.GetKey(KeyCode.UpArrow)? "UpArrow" : "DownArrow";
            speedAxis = speed * Input.GetAxis("Vertical");
             Debug.Log($"{key}: {speedAxis}");
        }
    }
}
