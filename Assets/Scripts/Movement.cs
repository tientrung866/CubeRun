using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform tr;
    public Rigidbody rb;
    [SerializeField] float forwardspeed = 2000f;
    [SerializeField] float sidesspeed = 500f;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World.");
    }

    private void Update()
    {
        
        if (Input.GetKey("right"))
        {
            moveright();
        }

        if (Input.GetKey("left"))
        {
            moveleft();
        }    
    }

    private void OnEnable()
    {
        rb.velocity = Vector3.zero;
    }
    
    private void moveright()
    {
        rb.AddForce(sidesspeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }

    private void moveleft()
    {
        rb.AddForce(-sidesspeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        rb.useGravity = true;
        // add a speed
        rb.AddForce(0,0,forwardspeed*Time.deltaTime);

        if (tr.position.y < 0f)
        {
            Debug.Log("Falling");
            FindObjectOfType<GameController>().EndGame();
        }

        // move left&right, put it into fixedupdate method making it slower.
        /*
        if (Input.GetKey("right"))
        {
            rb.AddForce(sidesspeed*Time.deltaTime,0,0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidesspeed*Time.deltaTime,0,0);
        }
        */

    }
}
