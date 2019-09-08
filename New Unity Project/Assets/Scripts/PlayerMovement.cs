using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public AudioClip Audio;
    private AudioSource Source;
    public Text text;

    public float verticalVelocity;
    private readonly float gravity = 100;
    private readonly float JumpForce = 50.0f;
    public float Speed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Source = GetComponent<AudioSource>();
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
            
            Source.PlayOneShot(Audio);
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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
    }
}
