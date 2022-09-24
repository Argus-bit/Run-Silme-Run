using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickVisible : MonoBehaviour
{
    public GameObject VisibleJoyStick;
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            VisibleJoyStick.gameObject.SetActive(false);
        }
        else { VisibleJoyStick.gameObject.SetActive(true); }
    }
}
