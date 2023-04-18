using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");
    public Vector2 speed = new Vector2(10, 10);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
