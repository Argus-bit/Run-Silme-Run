using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpSpaw : MonoBehaviour 
{ 

    public GameObject[] prefabPowerUp;
    public float spawTime;
    public float spawDelay;
    public Transform powerUpPoint;
    int random;

    void Start()
    {
        InvokeRepeating("SpawnRandom", spawTime, spawDelay);   
    }
    void SpawnRandom()
    {
        random = Random.Range(0, prefabPowerUp.Length);
        Instantiate(prefabPowerUp[Random.Range(0, prefabPowerUp.Length)], powerUpPoint);
    }




    /* private float timeCount;
     //public float timeToReset; Variável para resetar o tempo de uso do Prefab
     public Transform powerUpPoint;
     public bool SetSpaw = false;






     public void Update()
     {
         timeCount += Time.deltaTime;
         if (timeCount >= spawTime)
         {
             Instantiate(prefabPowerUp[Random.Range(0, prefabPowerUp.Length)], powerUpPoint);
             timeCount = 0;

         }

     }*/
}
