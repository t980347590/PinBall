using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;

    int pinballscore = 0;
    private GameObject pointtext;


    private void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.pointtext = GameObject.Find("Point");

    }

    private void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        this.pointtext.GetComponent<Text>().text = pinballscore + "pt";

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            pinballscore += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            pinballscore += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            pinballscore += 50;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            pinballscore += 30;
        }
    }

}