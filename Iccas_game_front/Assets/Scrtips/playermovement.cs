using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playermovement : MonoBehaviour
{
    public float rotationSpeed = 200f;

    public VariableJoystick joy;
    public VariableJoystick joy1;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 movement1;
    Vector2 mousePos;
    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = joy.Horizontal;
        movement.y = joy.Vertical;

        movement1.x = joy1.Horizontal;
        movement1.y = joy1.Vertical;
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookdir = movement1 - rb.position;
        float angles = (float) Math.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;

        if (movement1 != Vector2.zero)
        {
            float angle = Mathf.Atan2(movement1.y, movement1.x) * Mathf.Rad2Deg;
            Debug.Log(angle);
            rb.rotation = angle;
        }
   
        //rb.transform.rotation = Quaternion.Euler(0f, Mathf.Atan2(joy.Horizontal, joy.Vertical) * Mathf.Rad2Deg, 0f);
        //rb.transform.rotation = Quaternion.Euler(0f, Mathf.Atan2(joy.Horizontal, joy.Vertical) * Mathf.Rad2Deg, 0f);

        //Vector2 lookdir = mousePos - rb.position;
        //loat angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = angle;
    }
}
