using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    float a = 1f;
    float b = 10f;
    float c =.07f;

    private void Start()
    {
    }
    private void Update()
    {
        transform.localScale = new Vector3(a + Mathf.Sin(Time.time * b) * c, transform.localScale.y, a + Mathf.Sin(Time.time * b) * c);
    }
}