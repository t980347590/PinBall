using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{
    Material k;
    float l = .3f;
    float m = 2f;
    int n = 0;
    int p = 10;
    Color q = Color.white;


    private void Start()
    {
        k = GetComponent<Renderer>().material;

        k.SetColor("_EmissionColor", q * l);

        if (tag == "SmallStarTag") { q = Color.white; }
        else if (tag == "LargeStarTag") { q = Color.yellow; }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag") { q = Color.cyan; }



    }


    private void Update()
    {
        if (n >= 0)
        {
            Color r = q * (l + Mathf.Sin(n * Mathf.Deg2Rad) * m);
            k.SetColor("_EmissionColor", r);
            n -= p;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        n = 180;
    }



}