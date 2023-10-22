 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
 using UnityEngine.UIElements;

 public class JumpBehavour : MonoBehaviour
{
    public Rigidbody rb;
    public float gravity = 3f;
    public float jumpSpeed = 20f;

    private Vector3 position;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
