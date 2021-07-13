using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{


    Rigidbody2D playerRB;
    public float playerMovementSpeed = 200f;
    public float playerJumpHeight = 3f;

    public Animator animator;

    public bool isGrounded = false;

    public bool facing_right = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetFloat("Speed", Mathf.Abs(playerRB.velocity.x));
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (facing_right)
            {
                flip();
            }
            playerRB.velocity = new Vector2(-1f * playerMovementSpeed, playerRB.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!facing_right)
            {
                flip();
            }
            playerRB.velocity = new Vector2(1f * playerMovementSpeed, playerRB.velocity.y);
        }
        // else if (Input.GetKey(KeyCode.Space))
        // {
        //     if (isGrounded)
        //     {
        //         playerRB.AddForce(Vector2.up * playerJumpHeight, ForceMode2D.Impulse);
        //         isGrounded = false;
        //     }
        // }
    }

    private void flip()
    {
        facing_right = !facing_right;
        playerRB.transform.Rotate(0f, 180f, 0f);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
