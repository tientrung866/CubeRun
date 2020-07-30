using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement Movement;

    //public GameManager gameManager;
    
    //public Collision Collision;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (!collisionInfo.collider.CompareTag("Ground"))
        {
            Debug.Log(collisionInfo.collider.name);
            Movement.enabled = false;
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
