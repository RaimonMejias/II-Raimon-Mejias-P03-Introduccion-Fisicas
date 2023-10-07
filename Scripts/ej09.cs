using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej09 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other) {
        Debug.Log($"{other.gameObject.tag} ha colisionado con {name}");
    }
    
    void OnTriggerStay(Collider other) {
        Debug.Log($"{other.gameObject.tag} esta colisionado con {name}");
    }
}
