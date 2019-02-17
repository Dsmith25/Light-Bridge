using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float maxSpeed;
    bool facingLeft = false; 
    Animator anim;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce;
    Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //if we are on the ground and the space bar was pressed, change our ground state and add an upward force
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
    void FixedUpdate()
    {
        movePlayer();
    }
    
    // moves the player
    void movePlayer()
    {
        //set vSpeed
        anim.SetFloat("vSpeed", rb.velocity.y);
        //set grounded bool
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        //set ground in Animator to match grounded
        anim.SetBool("Ground", grounded);

        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move * maxSpeed, rb.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(move));

        //sets the sprite oritentation based on direction you are moving
        if (move < 0 && !facingLeft)
        {

            Flip();
        }
        else if (move > 0 && facingLeft)
        {
            Flip();
        }
    }

    //flips the orientation of the sprite 
    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
