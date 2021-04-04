using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// test
/// </summary>

public class collection_fruits : MonoBehaviour
{
    private int gold;
    private int chickens;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            gold++;
            Instantiate(Resources.Load("PickupEffect"), other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }

        if (other.tag == "chickens")
        {
            chickens ++;
            Instantiate(Resources.Load("PickupEffect"), other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
