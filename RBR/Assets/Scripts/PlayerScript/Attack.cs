using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private SpriteRenderer playerSprite;
    private Animator playerAnimator;

    public Transform pos;
    public Vector2 boxSize;

    //public float startAttackTime = 0.5f;
    //private float attackTime = 0.0f;
    //private bool isAttack = false;

    private Collider2D[] collider2Ds;
    private float coolTime = 0.5f;

    private void Start()
    {
        playerSprite = gameObject.GetComponent<SpriteRenderer>();
        playerAnimator = gameObject.GetComponent<Animator>();
        collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0, 0);
    }

    private void Update()
    {
        if (coolTime <= 0)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                playerAnimator.SetTrigger("Attack");
                coolTime = 0.4f;
            }
        }
        else
        {
            coolTime -= Time.deltaTime;
        }

        if (playerSprite.flipX)
            pos.localPosition = new Vector3(-1.7f, -1.25f);
        else
            pos.localPosition = new Vector3(1.7f, -1.25f);
    }

    private void FixedUpdate()
    {
        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.tag == "Enemy")
            {
                Debug.Log("때렸다");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
}