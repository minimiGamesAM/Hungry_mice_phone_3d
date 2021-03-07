using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Drag3d : MonoBehaviour
{
    float ZPosition;
    Vector3 offset;
    bool Dragging;
    public Camera MainCamera;

    UnityEvent m_MyEvent;

    [SerializeField]
    //public UnityEventQueueSystem OnEndDrag;
    public UnityEvent OnBeginDrag;
    public UnityEvent OnEndDrag;

    float smooth = 5.0f;

    public 

    // Start is called before the first frame update
    void Start()
    {
        ZPosition = MainCamera.WorldToScreenPoint(transform.position).z;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion target = Quaternion.Euler(0, 0, 0);


        if (Dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZPosition);

            //Vector2 position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            transform.position = MainCamera.ScreenToWorldPoint(position + new Vector3(offset.x, offset.y));
            //transform.position = MainCamera.ScreenToWorldPoint(position + new Vector2(offset.x, offset.y));
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        
    }
    void OnMouseDown()
    {
        if(!Dragging)
        {

            BeginDrag();
        }
    }
    private void OnMouseUp()
    {
        EndDrag();
    }
    public void BeginDrag()
    {
        Dragging = true;
        offset = MainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }
    public void EndDrag()
    {
        Dragging = false;
    }
}
