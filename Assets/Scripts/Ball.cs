using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour

{

    public Transform ObjectToMove;
    Rigidbody rb;
    public float  mass1 = 1f;
    //blic Rigidbody rb;
    //private bool isPressed = false;

    private float starPosX;
    private float starPosY;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
       rb.mass = mass1;

       





    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            ObjectToMove.position = this.transform.localPosition;

            starPosX = mousePos.x - this.transform.localPosition.x;
            starPosY = mousePos.y - this.transform.localPosition.y;

            Debug.Log("esta presionada" + this.transform.localPosition);
        }
        //rb.AddForce(transform.forward * 1000f);
        //Debug.Log("sdasd11222");
        //isPressed = true;
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(" no esta presionada");
        }
        //rb.AddForce(transform.forward * 1000f);
        //Debug.Log("sdasd11222");
        //isPressed = true;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            rb.AddForce(transform.forward * 1000f);
            
            
        }




    }



    

}
