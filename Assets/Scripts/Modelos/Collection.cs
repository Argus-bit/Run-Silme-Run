using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(162, 195)));
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rig.MovePosition(transform.position + transform.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.AddScore();
            Destroy(gameObject);
        }
    }
}
