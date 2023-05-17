using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1Anim : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rbody;
    Animator Walk_Anim;
    AnimatorControllerParameter isAttacking;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Walk_Anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Walk_Anim.SetBool("isAttacking", true);
            Walk_Anim.Play("Attack 1");
            Debug.Log("Attack");
        }
    }
}
