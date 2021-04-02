using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Resources.Load("Projectile"), transform.position, transform.rotation);
            Instantiate(Resources.Load("micil"), transform.position, transform.rotation);
        }
        
    }
}
