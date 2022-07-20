using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
	public GameObject prefab;
	public List<GameObject> pooledObjects;
	public int clones = 6;

	private void Awake()
	{
		StartPool();
	}

	private void StartPool()
	{
		pooledObjects = new List<GameObject>();
		for (int i = 0; i < clones; i++)
		{
			var obj = Instantiate(prefab, transform);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}

	}
	public GameObject GetPooledObject() {
		for (int i = 0; i< clones; i++)
		{
			if (!pooledObjects[i].activeInHierarchy)
			{
				return pooledObjects[i];
			}
		}
		return null;
	}
}
