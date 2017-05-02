using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance;

    public bool isGrounded = false;
    GameObject player;

    void Awake () {
        instance = new PlayerManager();
    }

    void Start () {
        player = GameObject.Find("Player");
    }

    void OnTriggerEnter2D (Collider2D coll) {
        if (coll.transform.tag == "Ground") {
            isGrounded = true;
        }
        isGrounded = true;
    }

    void OnTriggerExit2D (Collider2D coll) {
        if (coll.transform.tag == "Ground") {
            isGrounded = false;
        }
    }
}
