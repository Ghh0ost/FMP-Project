using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Walk : MonoBehaviour
{
    private float speed = 10.0f;
    private float horizontalInput;
    private float verticalInput;


    private Rigidbody2D rb;
    private Animator animator;
    public float jumpForce = 10f;

    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.left * Time.deltaTime * speed * horizontalInput);

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb.velocity = movement * speed;

        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        }
    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
        animator.SetBool("IsJumping", false);
    }
    }
 }


