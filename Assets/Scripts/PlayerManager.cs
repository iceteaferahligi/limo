using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance;

    public PlayerMovement playerMovement;


    void Start () {
        instance = this;
    }

    void OnTriggerEnter2D (Collider2D coll) {
        if (coll.transform.tag == "Ground") {
            playerMovement.isGrounded = true;
        }
       
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.transform.tag == "Ground")
        {
            playerMovement.isGrounded = true;
        }
       
    }

    void OnTriggerExit2D (Collider2D coll) {
        if (coll.transform.tag == "Ground") {
            playerMovement.isGrounded = false;
        }
    }
}
