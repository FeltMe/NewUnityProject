using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    private const int cameraXPositions = 4; //Make camera move
    private const float cameraSpeedCoefficient = 0.05f;

    public CharacterController controller;

    public AudioClip Audio;
    private AudioSource Source;
    public Text text;
    public new GameObject camera;
    public CoinCollector сoins;

    public float verticalVelocity;
    public float gravity = 100;
    public float JumpForce = 50.0f;
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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (camera.transform.position.x > -cameraXPositions)
            {
                camera.transform.Translate(Vector3.left * cameraSpeedCoefficient);
            }
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (camera.transform.position.x < cameraXPositions)
            {
                camera.transform.Translate(Vector3.right * cameraSpeedCoefficient);
            }
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
    }
    private void OnTriggerEnter(Collider collider) // Dimonds collector
    {
        if(collider.gameObject.name == "Star") 
        {
            сoins.IncrementPoints();
            Destroy(collider.gameObject);
        }
    }
}
