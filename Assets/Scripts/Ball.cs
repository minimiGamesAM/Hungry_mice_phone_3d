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
    private bool moving;

    private float starPosX;
    private float starPosY;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
       rb.mass = mass1;

       





    }
    void Update()

    {
        if(moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            //Debug.Log("mousePosFace1" + mousePos); // mouse position in pixels
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); /// transfor the mouse pixel position in cordinates world space
            //Debug.Log("mousePosFace2" + mousePos);
            //ObjectToMove.position = this.transform.localPosition;
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - starPosX, mousePos.y - starPosY, this.gameObject.transform.localPosition.z);
        }





    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            //Debug.Log("mousePosFace1" + mousePos); // mouse position in pixels
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); /// transfor the mouse pixel position in cordinates world space
            //Debug.Log("mousePosFace2" + mousePos);
            //ObjectToMove.position = this.transform.localPosition;// as the scrips is attache to the ball the cube in the public objecttomove is move at this possition
            
            starPosX = mousePos.x - this.transform.localPosition.x;
            starPosY = mousePos.y - this.transform.localPosition.y;



            Debug.Log("mousePos.x" + mousePos.x);
            Debug.Log("esta presionada" + this.transform.localPosition);
            moving = true;
        }
        //rb.AddForce(transform.forward * 1000f);
        //Debug.Log("sdasd11222");
        //isPressed = true;
    }

    private void OnMouseUp()
    {
        
        //rb.AddForce(transform.forward * 1000f);
        //Debug.Log("sdasd11222");
        //isPressed = true;
        moving = false;
    }

   



    

}
