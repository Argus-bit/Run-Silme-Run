using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    //Variáveis
    public float timeToReset; /*Variável para resetar o tempo de uso do Prefab*/
    public Rigidbody2D rig; /*Variável do movimento da plataforma.*/
    public float speed;
    private float timeCount;
    //Variáveis

    private void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount >= 10)
        {
            speed += 0.02f;
            timeCount = 0;
        }
    }
    void FixedUpdate()
    {


        rig.MovePosition(transform.position + transform.up * speed);

    }

    public void StartPlat()
    {
        Invoke(nameof(FinishUsage), timeToReset);
    }
    private void FinishUsage()
    {
        gameObject.SetActive(false);
    }
}
