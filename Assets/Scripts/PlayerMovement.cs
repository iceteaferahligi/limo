using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector2 velocity;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    float jumpSpeed = 3000f;

    float vVelocity = 0f;
    int direction = 1;



    //velocity
    private float value = 150;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = Vector2.zero;

        GameManager.instance.player = this.gameObject;

    }

    void Update()
    {
       


    }

    void FixedUpdate()
    {
        // physics calculation should be here


        velocity = Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * value;

        if (Input.GetKeyDown(Constants.jump))
        {
            
            rb.AddForce(Vector2.up * jumpSpeed);
        }
  

         
        if (velocity.x > 1)
        {
            direction = 1;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,1);
        }
        else
        {
           direction = -1;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*-1,transform.localScale.y,1);
        }
        
            
        

        rb.velocity = velocity - Vector2.up* 0.1f;


        if (Input.GetKeyDown(Constants.fire))
        {

            Fire();

        }
        
               
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }

    void OnCollisionStay2D(Collision2D coll) // C#, type first, name in second
    {
        if (coll.gameObject.tag == "Ground" && (Input.GetKey(KeyCode.W)))
        {
            //Jump Script
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);

        }
    }
}
