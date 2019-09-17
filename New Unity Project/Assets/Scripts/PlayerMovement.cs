using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public int cameraXPositions = 0; //Make camera move
    public float cameraSpeedCoefficient;

    public CharacterController controller;

    public AudioClip audio;
    private AudioSource source;
    public new GameObject camera;
    public CoinCollector сoins;

    public float verticalVelocity;
    public float gravity = 100;
    public float jumpForce = 50.0f;
    public float speed;
    private float currentPositionX;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
        currentPositionX = gameObject.transform.position.x;
    }
    private void Update()
    {
        AutooJump();
        Movement();
    }
    private void AutooJump()
    {
        if (controller.enabled)
        {
            if (controller.isGrounded)
            {
                source.PlayOneShot(audio);
                verticalVelocity = jumpForce;
            }
            else
            {
                verticalVelocity -= gravity * Time.deltaTime;
            }
            Vector3 moveV = new Vector3(0, verticalVelocity, 0);
            controller.Move(moveV * Time.deltaTime);
        }
    }

    private void Movement()
    {
        currentPositionX = Input.mousePosition.x;
        var pos = Camera.main.ViewportToScreenPoint(new Vector3(0.05f, 0, 0));

        if (currentPositionX - Camera.main.WorldToScreenPoint(gameObject.transform.position).x > pos.x)
        {
            if (camera.transform.position.x <= cameraXPositions)
            {
                camera.transform.Translate(Vector3.right * cameraSpeedCoefficient * Time.deltaTime);
            }
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (currentPositionX - Camera.main.WorldToScreenPoint(gameObject.transform.position).x < pos.x)
        {
            if (camera.transform.position.x >= -cameraXPositions)
            {
                camera.transform.Translate(Vector3.left * cameraSpeedCoefficient * Time.deltaTime);
            }
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider collider) // Dimonds collector
    {
        if (collider.gameObject.name == "Star")
        {
            сoins.IncrementPoints();
            Destroy(collider.gameObject);
        }
    }
}
