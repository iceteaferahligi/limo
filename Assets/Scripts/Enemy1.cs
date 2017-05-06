using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{

    int counter = 5;
    public GameObject enemy1;

    // Use this for initialization
   

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.transform.tag == "bullet")
        {

            if (counter == 1)
            {
                Destroy(enemy1);
            }
          
         counter--;

            Debug.Log(counter);
        }

    }
}
