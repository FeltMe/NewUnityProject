using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float verticalVelocity;
    private readonly float gravity = 80.0f;
    private readonly float JumpForce = 40.0f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            
                verticalVelocity = JumpForce;
            
        }
        else
        {
            verticalVelocity -=gravity * Time.deltaTime;
        }
        Vector3 moveV = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveV * Time.deltaTime);
    }
}
