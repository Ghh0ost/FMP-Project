using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Walk : MonoBehaviour
{
    private float speed = 10.0f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.left * Time.deltaTime * speed * horizontalInput);


    }
}
