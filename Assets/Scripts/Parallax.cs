using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material mat;
    float distance;

    [Range(0f, 0.5f)]
    public float speedParallax = 0.2f;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        distance += Time.deltaTime * speedParallax;
        mat.SetTextureOffset("_MainTex", Vector2.down * distance);
    }
}
