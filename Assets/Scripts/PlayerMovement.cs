using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animatorController;
    private float horizontalInput;
    private bool movingRight;

    public float speedModifier;
    public float jumpForce;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorController = GetComponent<Animator>();
        movingRight = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        animatorController.SetFloat("Speed", Mathf.Abs(horizontalInput));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
	}

    private void FixedUpdate()
    {
        if (horizontalInput < 0 && movingRight)
        {
            flip();
        }
        else if (horizontalInput > 0 && !movingRight)
        {
            flip();
        }
        rb.velocity = new Vector3(speedModifier * horizontalInput, rb.velocity.y, 0);
    }

    private void jump()
    {
        animatorController.SetTrigger("Jump");
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void flip()
    {
        if (movingRight)
        {
            transform.rotation = Quaternion.Euler(0, 190, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        movingRight = !movingRight;
    }
}
