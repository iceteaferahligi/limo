using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : MonoBehaviour {

    // Use this for initialization
    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(Constants.left)) {
            anim.SetBool("isRun", true);

            anim.SetFloat("sVelocity", 2f);
        }

          if(Input.GetKey(Constants.jump))
        {
            anim.SetBool("isJump", true);

            anim.SetFloat("sVelocity", 3f);
        }

                  
	}
}
