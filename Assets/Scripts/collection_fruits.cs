using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// test
/// </summary>

public class collection_fruits : MonoBehaviour
{
    private  int gold;
    public Text goldCount;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            gold++;
            goldCount.text = "Score:" + gold;
            Instantiate(Resources.Load("PickupEffect"), other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
