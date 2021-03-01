using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAle_moveObject : MonoBehaviour
{
    public GameObject correrF;
    private bool MoveObjeta;
    private float spY;
    private float spX;

    // Start is called before the first frame updates
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveObjeta)
        {
            Vector3 mousepost;
            mousepost = Input.mousePosition;
            mousepost = Camera.main.ScreenToWorldPoint(mousepost);
            this.gameObject.transform.localPosition = new Vector3(mousepost.x - spX, mousepost.y - spY, this.gameObject.transform.localPosition.z);


        }
        
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepost;
            mousepost = Input.mousePosition;
            mousepost = Camera.main.ScreenToWorldPoint(mousepost);

            spX = mousepost.x - this.transform.localPosition.x;
            spY = mousepost.y - this.transform.localPosition.y;
            MoveObjeta = true;
        }
        
    }
    void OnMouseUp()
    {
        MoveObjeta = false;
    }
}
