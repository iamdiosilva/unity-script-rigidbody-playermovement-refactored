using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
   private MovementController mController;
   
   private Vector3 xAxis, zAxis, fAxis;
   [SerializeField] private float axisSpeed = 5;

   private float xInput, zInput;

   private void Start()
   {
      mController = GetComponent<MovementController>();
   }

   private void Update()
   {
      InputHandler();
   }

   private void InputHandler()
   {
      xInput = Input.GetAxisRaw("Horizontal");
      zInput = Input.GetAxisRaw("Vertical");

      xAxis = axisSpeed * xInput * Vector3.right;
      zAxis = axisSpeed * zInput * Vector3.forward;

      fAxis = xAxis + zAxis;
      
      mController.SetFinalVector(fAxis);
   }
}
