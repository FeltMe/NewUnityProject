using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlatform : MonoBehaviour
{
    public CharacterController controller;
    public Animation animation;

    void Update()
    {
        if(controller.isGrounded)
        {
            animation.enabled = true;
        }
    }
}
