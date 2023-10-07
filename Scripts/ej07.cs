using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej07 : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;
        Vector3 targetPosition = targetObject.transform.position;
        Vector3 movement = (targetPosition - transform.position).normalized;
        transform.LookAt(targetObject.transform);
        transform.Translate(movement * distance, Space.World);
        
    }
}
