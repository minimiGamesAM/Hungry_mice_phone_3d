using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// test
/// </summary>

public class collection_fruits : MonoBehaviour
{
    private int gold;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            gold++;
            Destroy(other.gameObject);
        }
    }
}
