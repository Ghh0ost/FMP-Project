using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Walk : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rbody;
    Animator Walk_Anim;
    AnimatorControllerParameter isWalking;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Walk_Anim = GetComponent<Animator>();
    }
    void Update()
    {
        var move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (move != 0)
        {
            Walk_Anim.SetBool("isWalking", true);
            Walk_Anim.Play("Walk_Anim");
            Debug.Log("Walk");
;        }

        if (move == 0)
        {
            Walk_Anim.SetBool("isWalking", false);
            Walk_Anim.Play("Knight idle");
            Debug.Log("Idle");
        }
    }
}



