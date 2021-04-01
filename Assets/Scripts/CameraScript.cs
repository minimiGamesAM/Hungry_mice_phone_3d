using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//game Prototipe for test

public class CameraScript : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X")+ Input.GetAxis ("HorizontalRight");
        pitch -= speedV * Input.GetAxis("Mouse Y") + Input.GetAxis("VerticalRight");

        

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);



    }
}