using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  in test
/// </summary>

public class Projectile : MonoBehaviour
{
    public Text chikentCount;
    private int chickens;

    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 50);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            chickens++;
            //chikentCount.text = "Enemies destroyed" + chickens;
            Instantiate(Resources.Load("Chicken"), other.transform.position, Quaternion.Euler(90,0,0));
            
            Destroy(other.gameObject);
            //Destroy(gameObject);
        }


    }
}
