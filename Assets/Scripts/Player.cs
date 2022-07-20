using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Vector2 dir;
	public float speed = 3f;
	//public float jumpForce = 800f;
	public bool facingRight = true;
	public float movX;
	private Rigidbody2D rb;
	private Transform _transform;
	public GameObject _gameObject;
    /*private bool jumping;*/

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		_transform = GetComponent<Transform>();
	}
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
    void FixedUpdate()
    {
        Move();
        /*Jump();*/
    }
    void Move()
    {
        movX = Input.GetAxis("Horizontal");
        if (movX > 0 && !facingRight)
        { Flip();
        Destroy(_gameObject);
        }
        else if (movX < 0 && facingRight)
        { Flip();
        Destroy(_gameObject);
        }
        rb.velocity = new Vector2(movX * speed, rb.velocity.y);
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    /* void Jump()
    {
        var AbsVelY = Mathf.Abs(rb.velocity.y);
        jumping = AbsVelY >= 0.5;
        if (Input.GetKeyDown("up") && !jumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        }
    }*/
}