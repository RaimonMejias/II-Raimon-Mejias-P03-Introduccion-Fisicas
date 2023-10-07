using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej05 : MonoBehaviour
{
    public float speed = 1.0f;
    public bool WASD = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = 0.0f;
        float verticalMovement = 0.0f;
        float movement = 1.0f * speed * Time.deltaTime;
        if (Input.GetKey((WASD)? KeyCode.A : KeyCode.LeftArrow)) { horizontalMovement = -movement; }
        if (Input.GetKey((WASD)? KeyCode.D : KeyCode.RightArrow)) { horizontalMovement = movement; }
        if (Input.GetKey((WASD)? KeyCode.W : KeyCode.UpArrow)) { verticalMovement = movement; }
        if (Input.GetKey((WASD)? KeyCode.S : KeyCode.DownArrow)) { verticalMovement = -movement; }
        transform.Translate(horizontalMovement, 0, verticalMovement);
    }
}
