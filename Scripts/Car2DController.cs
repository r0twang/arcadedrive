using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum controlMode
{
    KeyBoard, Touch
}

public class Car2DController : MonoBehaviour
{
    bool setAccelerate = false;
    bool setBrake = false;
    bool setTouchAccelerate, setTouchBrake;
    bool setTouchLeft, setTouchRight;
    float speed = 13.0f;
    float torque = -200.0f;
    float driftFactorSticky = 0.9f;
    float driftFactorSlippy = 1.0f;
    float maxStickyVelocity = 2.5f;

    public controlMode carControlMode;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        //if (Input.touches.Length > 0)
        //{
        //    transform.Translate(Input.touches[0].deltaPosition.x * Time.deltaTime, 0f, 0f);
        //    transform.Translate(0f, 0f, Input.touches[0].deltaPosition.y * Time.deltaTime);
        //}

        //EnterCarScript.isPlayerInAnyCar = true;
        //if (EnterCarScript.isPlayerInAnyCar)
        //{
        //if (Input.GetButtonDown("Accelerate"))
        //{
        setAccelerate = true;
        //}
        //else
        if (Input.GetButtonDown("Brakes"))
        {
            setBrake = true;
        }
        if (Input.GetButtonUp("Accelerate"))
        {
            setAccelerate = false;
        }
        else if (Input.GetButtonUp("Brakes"))
        {
            setBrake = false;
        }
        //}
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Rigidbody2D rigBod2 = GetComponent<Rigidbody2D>();

        float driftFactor = driftFactorSticky;
        if (RightVelocity().magnitude > maxStickyVelocity)
        {
            driftFactor = driftFactorSlippy;
        }

        float tf = Mathf.Lerp(0, torque, rigBod2.velocity.magnitude / 4);

        if (carControlMode == controlMode.KeyBoard)
        {
            if (Input.touches.Length > 0)
            {
                rigBod2.velocity = ForwardVelocity() + RightVelocity() * driftFactor;
            }

            if (setAccelerate == true)
            {
                rigBod2.AddForce(transform.up * speed);
            }

            //float tf = Mathf.Lerp(0, torque, rigBod2.velocity.magnitude / 4);

            rigBod2.angularVelocity = Input.GetAxis("Horizontal") * tf;

            if (setBrake == true)
            {
                rigBod2.AddForce(transform.up * (-1) * (speed / 1));
            }
        }
        else if (carControlMode == controlMode.Touch)
        {
            if (setTouchLeft)
                transform.Rotate(Vector3.forward * tf);
            else if (setTouchRight)
                transform.Rotate(Vector3.back * tf);
        }

    }

    public Vector2 ForwardVelocity()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.up);
    }

    public Vector2 RightVelocity()
    {
        return transform.right * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.right);
    }

    public void SetTouchAccel(bool TouchState)
    {
        setTouchAccelerate = TouchState;
    }

    public void SetTouchBreaks(bool TouchState)
    {
        setTouchBrake = TouchState;
    }

    public void SetSteerLeft(bool TouchState)
    {
        Debug.Log("LEFT");
        setTouchLeft = TouchState;
    }

    public void SetSteerRight(bool TouchState)
    {
        Debug.Log("RIGHT");
        setTouchRight = TouchState;
    }
}