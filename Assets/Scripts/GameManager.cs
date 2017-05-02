using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;

    public static GameManager instance { get; set; }

    private void Awake () {
        instance = this;
    }


    void Start () {

        
    }


    void Update () {

    }
}
