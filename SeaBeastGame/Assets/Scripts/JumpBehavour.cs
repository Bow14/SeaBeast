 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
 using UnityEngine.UIElements;
 using UnityEngine.Events;

 public class JumpBehavour : MonoBehaviour
 {
     public Rigidbody rb;
     public float gravity = 3f;
     public float jumpSpeed = 20f;
     public InputAction controls;
     public UnityEvent collsions;

     private Vector3 position;

     private void OnEnable()
     {
         controls.Enable();

     }

     private void OnDestroy()
     {
         controls.Disable();
     }

     private void Start()
     {
         rb = GetComponent<Rigidbody>();
     }

     //this section was helped with  https://www.youtube.com/watch?v=24-BkpFSZuI
     public void Jumping(InputAction.CallbackContext context)
     {
         if (context.performed)
         {
             rb.velocity = new Vector3(rb.velocity.x, jumpSpeed);
         }

         if (context.canceled && rb.velocity.y > 0.5f)
         {
             rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y * 0.5f);
         }
     }

     private void Update()
     {
         position = controls.ReadValue<Vector3>();
     }

     private void OnTriggerEnter(Collider other)
     {

         if (other.CompareTag("Danger"))
         {

             collsions.Invoke();
         }

     }
 }
