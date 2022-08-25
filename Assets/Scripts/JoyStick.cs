using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    private Touch touch;
    private Vector2 startPos;
    public Transform backGround;
    void Start()
    {
        touch = new Touch { fingerId = -1 };
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int a = 0; a < Input.touchCount; a++)
            {
                if (touch.fingerId == -1)
                {
                    if (Input.GetTouch(a).position.y < Screen.height / 3)
                    {
                        touch = Input.GetTouch(a);
                        startPos = touch.position;
                        backGround.position = startPos;
                    }
                }
                else
                {
                    if (Input.GetTouch(a).fingerId == touch.fingerId)
                    {
                        touch = Input.GetTouch(a);
                    }
                }
            }
            if (touch.fingerId != -1)
            {
                if (touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended)
                {
                    touch = new Touch { fingerId = -1 };
                }
                else
                {
                    Vector2 dist = touch.position - startPos;
                    transform.position = startPos + Vector2.ClampMagnitude(dist, 70);
                }
            }
        }
        if(touch.fingerId == -1)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPos, 10);
        }
    }
}
