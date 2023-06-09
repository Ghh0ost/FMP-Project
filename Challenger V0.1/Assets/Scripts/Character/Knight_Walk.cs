using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Walk : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rbody;
    Animator Walk_Anim;
    AnimatorControllerParameter isWalking;
    AnimatorControllerParameter isIdle;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Walk_Anim = GetComponent<Animator>();
    }
    void Update()
    {
        var move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            //Walk_Anim.SetBool("isAttack", true);
            Walk_Anim.SetTrigger("Attack");
            Walk_Anim.Play("Attack");

        } 
        else 
        { 

            if (move != 0)
            {
                Walk_Anim.SetBool("isIdle", false);
                //Walk_Anim.SetBool("isAttack", false);
                //Walk_Anim.Play("Walk_Anim");
                //Debug.Log("Walk");
    ;        }

            if (move == 0)
            {
                Walk_Anim.SetBool("isIdle", true);
                //Walk_Anim.SetBool("isAttack", false);
                //Walk_Anim.Play("Knight idle");
                //Debug.Log("Idle");
            }

        }

        /*
        if (Input.GetMouseButtonDown(0) && move == 0)
        {
            Walk_Anim.SetBool("isIdle", true);

            //Debug.Log("Attack is idle false");
        }

        if (Input.GetMouseButtonDown(0) && move != 0)
        {
            Walk_Anim.SetBool("isIdle", false); 

            //Debug.Log("Attack is walking false");
        }
        */
    }
}



