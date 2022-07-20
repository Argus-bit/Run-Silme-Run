using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muv : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 800f;
    public bool facingRight = true;
    public float movX;
    private Rigidbody2D rb;
    private Transform transform;
    public GameObject gameObject;

    private bool jumping;
    //private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        //playerAnimator = GetComponent<Animator>();
        
    }
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        { Destroy(gameObject); }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Jump();
    }
    void Move() 
    {
        movX = Input.GetAxis ("Horizontal");
        if (movX > 0 && !facingRight)
        { Flip();}
       else if (movX < 0 && facingRight) 
        { Flip();}
        rb.velocity = new Vector2(movX * speed, rb.velocity.y);
        /*if (movX != 0) { playerAnimator.SetBool-->("Andando", true); }
        else { playerAnimator.SetBool("Andando", false); }*/
    }
    void Flip() 
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    void Jump() 
    {
        var AbsVelY = Mathf.Abs (rb.velocity.y);
        jumping = AbsVelY >= 0.5;
        if (Input.GetKeyDown("up") && !jumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
           /* playerAnimator.SetBool("Jump", true);*/
        }
       /* else if (!jumping)
       { playerAnimator.SetBool("Jump", false); }*/
    }
}

