using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_scale : MonoBehaviour
{
    private Vector3 scaleChange;
    public Transform object1;
    public float scaleFactor  = -0.1f;
    public float scaleFactor2 = 0.1f;
    public float speedScale = .1f;

    // Start is called before the first frame update

    private void Awake()
    {
        scaleChange = new Vector3(scaleFactor, scaleFactor2, scaleFactor)*Time.deltaTime*speedScale;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        object1.transform.localScale += scaleChange;

        if (object1.transform.localScale.y < 0.97f || object1.transform.localScale.y > 1.05f)
        {
            scaleChange = -scaleChange;
            //positionChange = -positionChange;
        }

    }
}
