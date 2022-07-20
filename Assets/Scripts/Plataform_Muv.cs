using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_Muv : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRight;
    public float speed;
    public float Wallr;
    public float Walll;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else { transform.Translate(-Vector2.right * speed * Time.deltaTime); }
        if (transform.position.x >= Wallr || transform.position.x <= Walll)
        { isRight = !isRight; }
    }

}
