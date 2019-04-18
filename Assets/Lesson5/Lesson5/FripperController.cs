using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    HingeJoint myHingeJoint;
    float defaultAngle = 20f;
    float flickAngle = -20f;

    bool leftbool;
    bool rightbool;




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

        leftbool = false;
        rightbool = false;

    }



    bool DetectTouches(ref bool isLeftTouched, ref bool isRightTouched)
    {
        Touch[] touches = Input.touches;
        if (touches.Length < 1)
            return false;

        foreach (var touch in touches)
        {
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    isRightTouched = true;
                }
                else
                {
                    isLeftTouched = true;
                }
            }
        }
        return true;
    }

    private void Update()
    {


        leftbool = false;
        rightbool = false;

        if (DetectTouches(ref leftbool, ref rightbool))
        {

            if (tag == "LeftFripperTag")
            {
                if (leftbool)
                {
                    SetAngle(flickAngle);
                }
                else
                {
                    SetAngle(defaultAngle);
                }

            }

            if (tag == "RightFripperTag")
            {
                if (rightbool)
                {
                    SetAngle(flickAngle);
                }
                else
                {
                    SetAngle(defaultAngle);
                }
            }

        }



        if (tag == "LeftFripperTag")
        {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                SetAngle(flickAngle);

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {

                SetAngle(defaultAngle);

            }
        }


        if (tag == "RightFripperTag")
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {

                SetAngle(flickAngle);
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {

                SetAngle(defaultAngle);
            }
        }







    }



}



