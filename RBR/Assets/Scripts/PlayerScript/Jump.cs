using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private Animator playerAnimator;

    public float jumpForce;

    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) && playerBody.velocity.normalized.y == 0
            && !playerAnimator.GetBool("isFalling"))
        {
            playerAnimator.SetTrigger("Jump");
            playerAnimator.SetTrigger("Falling");
            playerAnimator.SetBool("isFalling", true);
            playerBody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            playerAnimator.SetBool("isFalling", false);
        }
    }

    private void FixedUpdate()
    {
    }
}