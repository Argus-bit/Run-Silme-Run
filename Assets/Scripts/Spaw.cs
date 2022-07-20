using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    public GameObject Prefabplataform;
    public float spawTime;
    private float timeCount;
    public PoolManager poolManager;
    public Transform spawPointOne;
    public void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount >= spawTime)
        {
            SpawObject();
            timeCount = 0;
        }
    }
    private void SpawObject()
    {
        var obj = poolManager.GetPooledObject();
        obj.SetActive(true);
        obj.transform.SetParent(null);
        obj.GetComponent<Plataform>().StartPlat();
        obj.transform.position = spawPointOne.transform.position;
    }
}
