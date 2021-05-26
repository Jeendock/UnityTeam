using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private SpriteRenderer playerSprite;
    private Animator playerAnimator;

    public float maxSpeed;
    public float acceleration;

    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
        playerSprite = gameObject.GetComponent<SpriteRenderer>();
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonUp("Horizontal"))
            playerBody.velocity = new Vector2(playerBody.velocity.normalized.x * 0.5f, playerBody.velocity.y);

        // Move Speed
        float h = Input.GetAxisRaw("Horizontal");
        playerBody.AddForce(Vector2.right * (h * acceleration), ForceMode2D.Impulse);

        // Max Speed
        if (playerBody.velocity.x > maxSpeed)
            playerBody.velocity = new Vector2(maxSpeed, playerBody.velocity.y);
        else if (playerBody.velocity.x < maxSpeed * (-1))
            playerBody.velocity = new Vector2(maxSpeed * (-1), playerBody.velocity.y);

        if (Input.GetButton("Horizontal"))
            playerSprite.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if (Mathf.Abs(playerBody.velocity.x) < 0.2)
            playerAnimator.SetBool("isRun", false);                             //IDLE
        else if (Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.K))
            playerAnimator.SetBool("isRun", true);                              //RUN
    }
}