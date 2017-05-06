using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject target;
    Vector3 currentPosition;
   

    // Use this for initialization
    void Start () {
        currentPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.SmoothDamp(transform.position, target.transform.position + new Vector3(3, 2, -0.3f),ref currentPosition, 0.4f);

    }
}
