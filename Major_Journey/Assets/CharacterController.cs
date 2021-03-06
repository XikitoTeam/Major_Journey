﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Collider
    private IsGrounded feed = null;
    //Rigidbody
    private Rigidbody rb;

    //Variables
    public int MoveSpeed;
    public int RotateSpeed;
    public int JumpForce;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        feed = GameObject.Find("Feed").GetComponent<IsGrounded>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        Jump();





    }



    private void Move()
    {
        // Movimiento 

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate((Vector3.forward * MoveSpeed) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate((Vector3.forward * -MoveSpeed) * Time.deltaTime);

        }
    }

    private void Rotate()
    {

        // Rotacion

       if (Input.GetKey(KeyCode.A))
       {

          transform.Rotate((Vector3.up * -RotateSpeed) * Time.deltaTime);

       }

       if (Input.GetKey(KeyCode.D))
       {

          transform.Rotate((Vector3.up * RotateSpeed) * Time.deltaTime);

       }

    }

    private void Jump()
    {
        // Salto

        if (Input.GetKey(KeyCode.Space) && feed.is_grouned) rb.AddForce((Vector3.up * JumpForce), ForceMode.Impulse);

    }
}

