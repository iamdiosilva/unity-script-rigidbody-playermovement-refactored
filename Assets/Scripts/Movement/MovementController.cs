using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    private Rigidbody rb;

    private Vector3 finalVector;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //MoveByPosition();
        //MoveByForce();
        //MoveByVelocity();
        MoveByAcceleration();
        
        
    }

    public void SetFinalVector(Vector3 vector)
    {
        finalVector = vector;
    }

    private void MoveByPosition()
    {
        rb.MovePosition(rb.position + finalVector * Time.deltaTime);
    }

    private void MoveByAcceleration()
    {
        rb.AddForce(finalVector * rb.mass);
    }
    
    private void MoveByForce()
    {
        rb.AddForce(finalVector);
    }

    private void MoveByVelocity()
    {
        rb.velocity = finalVector;
    }

    
}
