using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {

    int a = 0;
    private GameObject b;


    // Use this for initialization
    void Start () {
		this.b= GameObject.Find("Point");
    }
	
	// Update is called once per frame
	void Update () {
        this.b.GetComponent<Text>().text = a+"pt";

    }

   private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag") { a += 10; }
        else if (other.gameObject.tag == "LargeStarTag") { a += 30; }
        else if (other.gameObject.tag == "SmallCloudTag") { a += 50; }
        else if (other.gameObject.tag == "LargeCloudTag") { a += 30; }
    }

}
