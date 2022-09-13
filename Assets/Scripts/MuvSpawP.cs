using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuvSpawP : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRight;
    public float speed;
    public float Wallr;
    public float Walll;

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }
        else { transform.Translate(speed * Time.deltaTime * -Vector2.right); }
        if (transform.position.x >= Wallr || transform.position.x <= Walll)
        { isRight = !isRight; }
    }
}
