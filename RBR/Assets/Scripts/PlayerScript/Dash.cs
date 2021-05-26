using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private SpriteRenderer playerSprite;
    private Animator playerAnimator;

    public float dashSpeed = 0;
    public float startDashTime = 0;
    private float dashTime = 0;
    private bool isDash = false;

    private float coolTime = 0.3f;

    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
        playerSprite = gameObject.GetComponent<SpriteRenderer>();
        playerAnimator = gameObject.GetComponent<Animator>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        if (coolTime <= 0)
        {
            if (isDash == false)
            {
                if (Input.GetKeyDown(KeyCode.K) && playerBody.velocity.y == 0)
                {
                    isDash = true;
                }
            }
            else
            {
                if (dashTime <= 0)
                {
                    isDash = false;
                    dashTime = startDashTime;
                    coolTime = 0.3f;
                }
                else
                {
                    dashTime -= Time.deltaTime;
                    playerAnimator.SetTrigger("Dash");

                    if (isDash == true)
                    {
                        if (playerSprite.flipX)
                            playerBody.AddForce(Vector2.left * dashSpeed, ForceMode2D.Force);
                        else
                            playerBody.AddForce(Vector2.right * dashSpeed, ForceMode2D.Force);
                    }
                }
            }
        }
        else
        {
            coolTime -= Time.deltaTime;
        }
    }

    public bool GetIsDash()
    {
        return isDash;
    }
}