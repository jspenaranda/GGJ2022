using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    float horizontalMove = 0f;
    bool faceRight = true;
    bool isGrounded;

    PlayerSFX myPlayer;

    [SerializeField] bool extraJump = false;
    

    Rigidbody2D myRigidBody;
    [SerializeField] Transform groundCheck;
    [SerializeField] float radiusCheck;
    [SerializeField] LayerMask whatIsGround;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myPlayer = GetComponent<PlayerSFX>();;
    }

    void Update()
    {
        Jump();
    }

   
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, radiusCheck, whatIsGround);
        if (isGrounded)
        {
            extraJump = true;
        }
        
        Walk();

        if (faceRight == false && horizontalMove > 0)
        {
            Flip();
        }
        else if (faceRight == true && horizontalMove < 0)
        {
            Flip();
        }
    }

    private void Walk()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        myRigidBody.velocity = new Vector2(horizontalMove, myRigidBody.velocity.y);

        if (Mathf.Abs(horizontalMove) > 0 && isGrounded)
        {
            myPlayer.PlayWalk();
        }       
    }

    private void Jump()
    {
        if (isGrounded == true && Input.GetButtonDown("Jump") && myRigidBody.gravityScale > 0)
        {
            myRigidBody.velocity = Vector2.up * jumpForce;
            myPlayer.PlayJump();
        }
        if (isGrounded == true && Input.GetButtonDown("Jump") && myRigidBody.gravityScale < 0)
        {
            myRigidBody.velocity = Vector2.down * jumpForce;
            myPlayer.PlayJump();
        }

        if (isGrounded == false &&
            extraJump &&
            Input.GetButtonDown("Jump") && myRigidBody.gravityScale > 0)
        {
            myRigidBody.velocity = Vector2.up * jumpForce;
            extraJump = false;
            myPlayer.PlayJump();
        }

        if (isGrounded == false &&
            extraJump &&
            Input.GetButtonDown("Jump") && myRigidBody.gravityScale < 0)
        {
            myRigidBody.velocity = Vector2.down * jumpForce;
            extraJump = false;
            myPlayer.PlayJump();
        }
    }

    void Flip()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
