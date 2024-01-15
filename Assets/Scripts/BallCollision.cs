using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public event Action CollisionEntered;

    private void OnCollisionEnter(Collision collision)
    {
        var rigidbody = collision.collider.attachedRigidbody;

        if (rigidbody != null)
        {
            if (rigidbody.GetComponent<Ball>() != null)            
                CollisionEntered?.Invoke();            
        }
    }
}
