using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{

    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("ss");
        if (coll.transform.tag == "Gcheck")
        {
            player.GetComponent<PlayerMovement>().isGrounded = true;
        }

    }
    void OnTriggerStay2D(Collider2D coll)
    {

        if (coll.transform.tag == "Gcheck")
        {
            player.GetComponent<PlayerMovement>().isGrounded = true;
        }

    }

    void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("ss");
        if (coll.transform.tag == "Gcheck")
        {
            player.GetComponent<PlayerMovement>().isGrounded = false;
        }
    }
}
