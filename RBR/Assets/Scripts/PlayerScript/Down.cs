using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    private Animator playerAnimator;

    bool isdown = false;

    private void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(downjump());
        }
    }

    IEnumerator downjump()
    {
        isdown = true;
        yield return new WaitForSeconds(0.2f);
        isdown = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            playerAnimator.SetBool("isFalling", false);
            if (isdown)
                collision.gameObject.GetComponent<PlatformEffector2D>().rotationalOffset = 180.0f;
            else
                collision.gameObject.GetComponent<PlatformEffector2D>().rotationalOffset = 0.0f;
        }
        if (collision.gameObject.tag == "Ground")
        {
            playerAnimator.SetBool("isFalling", false);
        }
    }
}