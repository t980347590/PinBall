using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    HingeJoint myHingeJoint;
    float defaultAngle = 20f;
    float flickAngle = -20f;






    void SetAngle(float angle)
    {
        JointSpring jointSpr = myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        myHingeJoint.spring = jointSpr;
    }




    private void Start()
    {
        myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(defaultAngle);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(flickAngle);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(defaultAngle);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(defaultAngle);
        }


        //以下発展課題


        for (int i = 0; i < Input.touchCount; ++i)
        {

            Touch t = Input.GetTouch(i);





            if (tag == "LeftFripperTag")
            {
                if (t.position.x <= Screen.width * 0.5f)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        SetAngle(flickAngle);
                    }
                    else if (Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        SetAngle(defaultAngle);
                    }
                }
                else if (t.position.x > Screen.width * 0.5f)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        SetAngle(defaultAngle);
                    }
                }
            }


            if (tag == "RightFripperTag")
            {
                if (t.position.x > Screen.width * 0.5f)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        SetAngle(flickAngle);
                    }
                    else if (Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        SetAngle(defaultAngle);
                    }
                }
                else if(t.position.x <= Screen.width * 0.5f)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        SetAngle(defaultAngle);
                    }
                }
            }
        }







    }
}



