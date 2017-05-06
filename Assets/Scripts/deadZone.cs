using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadZone : MonoBehaviour {

    /// <summary>
    /// //
    /// </summary>
    int lives = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        //GM.instance.LoseLife();
        if (col.transform.tag == "Player")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }

}
