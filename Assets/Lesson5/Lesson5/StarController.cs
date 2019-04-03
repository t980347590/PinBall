using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{
    private float x = 1.0f;

    private void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);
    }
    private void Update()
    {
        transform.Rotate(0, x, 0);
    }
}