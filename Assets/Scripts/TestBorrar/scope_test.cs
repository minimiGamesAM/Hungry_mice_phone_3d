using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scope_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n1 = 1;
        int n2 = 3;
        int n3 = 4:

            int asw =
            Assn(n1, n2) + Assn(n3, n1);

        dispelre(asw);


        string b1 = "b1";
        {
            string b2 = "b2";
            Debug.Log(b2);
            {
                string b3 = "b3";
                Debug.Log(b3);
                Debug.Log(b2);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Assn( int a, int b)
    {
        int ress = a + b;
        return ress;

    }
    void dispelre( int total)
    {
        Debug.Log("el re" + total);
    }

}
