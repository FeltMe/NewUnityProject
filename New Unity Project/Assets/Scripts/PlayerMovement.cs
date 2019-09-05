using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float verticalVelocity;
    private readonly float gravity = 150;
    private readonly float JumpForce = 73.0f;
    public float Speed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        AutooJump();
        TempMovement();
    }
    private void AutooJump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            verticalVelocity = JumpForce;
        }
        else
        {       
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveV = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveV * Time.deltaTime);
    }
    
    private void TempMovement()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(-Vector3.right * Time.deltaTime * Speed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-Vector3.left * Time.deltaTime * Speed);
        }
    }
}
