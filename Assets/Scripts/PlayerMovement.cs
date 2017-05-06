using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocity;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public PlayerManager pm;
    public float jumpForce = 200f;
    float scaleX;
    float horizontalAxisInput;
    public float maxSpeed;
    bool jumping = false;
    public bool isGrounded = true;

    float vVelocity = 0f;
    int direction = 1;


    //velocity
    private float value = 100;

    void Start()
    {
       
        GameManager.instance.player = this.gameObject;
        pm = GameObject.Find("Ground Checker").GetComponent<PlayerManager>();

        rb = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;

    }

    void Update()
    {

        jumping = Input.GetKeyDown(Constants.jump);

        if (jumping/* && isGrounded*/)
        {
            rb.AddForce(Vector2.up * jumpForce);
           
        }
        jumping = false;

    }



    void FixedUpdate()
    {
        // physics calculation should be here

        horizontalAxisInput = Input.GetAxis("Horizontal");


        Vector3 easeVelocity = rb.velocity;
        easeVelocity.y = rb.velocity.y;
        easeVelocity.z = 0;
        easeVelocity.x *= 0.75f;


        rb.velocity = easeVelocity;


        horizontalAxisInput = Input.GetAxis("Horizontal");

        if (horizontalAxisInput < -0.1F)
        {
            transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        }
        else if (horizontalAxisInput > 0.1F)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        rb.AddForce(Vector2.right * horizontalAxisInput * velocity);
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }


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

        // Destroy the bullet after 1 seconds
        Destroy(bullet, 1.0f);
    }

   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "coin")
        {
            Destroy(col.gameObject);
            //CoinScript.instance_.calculateCoin();
        }

        if(col.transform.tag == "meteor")
        {
            //GM.instance.LoseLife();
        }
    }

}
