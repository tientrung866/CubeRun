using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -9.5)
        {
            SimplePool.Despawn(gameObject);
            //Destroy(gameObject);
        }
    }
    
}
