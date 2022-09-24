using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public VariableJoystick joystick;
	public float speed = 3f;
	public bool facingRight = true;
	public float movX;
	private Rigidbody2D myRigidbody;
	private Transform _transform;
	public GameObject _gameObject;
    public Vector2 friction = new Vector2(.1f, 0);

    void Start()
	{
        myRigidbody = GetComponent<Rigidbody2D>();
		_transform = GetComponent<Transform>();
	}
    public void OnDestroy()
    {
        Destroy(gameObject);
        Score.stopTime = true;
    }
    void FixedUpdate()
    {
        AspectMove();
    }
    void AspectMove()
    {
         movX = joystick.Horizontal;
         myRigidbody.velocity = new Vector2(movX * speed, myRigidbody.velocity.y);

        // CHAMADA DA FUNÇÃO Flip(); QUE GERA O FLIP DA IMAGEM DO PERSONAGEM, O FAZENDO VIRAR O ROSTO
        if (movX > 0 && !facingRight)
        { 
            Flip();
            Destroy(_gameObject);
        }
        else if (movX < 0 && facingRight)
        { 
            Flip();
            Destroy(_gameObject);
        }

        //FUNÇÃO QUE RETIRA O ATRITO DO PERSONAGEM COM AS PLATAFORMAS
        if (myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity += friction;
        }
        else if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity -= friction;
        }
    }

    // FUNÇÃO QUE GERA O FLIP DA IMAGEM DO PERSONAGEM, O FAZENDO VIRAR O ROSTO
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}