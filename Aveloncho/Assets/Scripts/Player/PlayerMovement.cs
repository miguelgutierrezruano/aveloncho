using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement var
    private float currentSpeed;
    [SerializeField] float speed;
    [SerializeField] Vector2 movementDirection;

    // Self references
    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // X axis control
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            movementDirection.x = -1;
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            movementDirection.x = 1;
        else
            movementDirection.x = 0;

        // Y axis control
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
            movementDirection.y = -1;
        else if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            movementDirection.y = 1;
        else
            movementDirection.y = 0;

        movementDirection.Normalize();

        // Speed calculation
        currentSpeed = speed;

        // Movement physics
        rb.velocity = movementDirection * currentSpeed;



    }
}
