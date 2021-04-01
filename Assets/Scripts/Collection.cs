using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// game tes
/// </summary>
public class Collection : MonoBehaviour
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

