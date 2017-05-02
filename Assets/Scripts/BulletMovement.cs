using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    int direction = 1;

	// Use this for initialization
	void Start () {


        if (GameManager.instance.player.transform.localScale.x > 0)

            direction = 1;

        else

            direction = -1;


    }
	
	// Update is called once per frame
	void Update () {

            transform.Translate(direction * Time.deltaTime * 10, 0, 0);
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "case")
        {
            Destroy(col.gameObject);
        }

        if(col.transform.tag == "enemy1")
        {
            Destroy(col.gameObject);
        }
        if(col.transform.tag == "bigboss")
        {
            Destroy(col.gameObject);
        }
       
       
    } 
  
}
