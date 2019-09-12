using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private const float defaultPlatfromMovementSpeed = 52.5f;
    private const float firstPlatformSpeed = 25.5f;
    private const float gravity = 100;
    private const float playerSpeed = 40;
    private const float verticalVelocity = 75;
    private const float jumpForce = 50;

    public MovePlatformScript[] firstFourPlatforms;
    public MovePlatformScript PlatformScript;
    public PlayerMovement player;
    public GameObject StartBtn;
    public GameObject ThemeBtn;
    public Text ThemeButtonText;
    public new Camera camera;

    private bool SwitcherOfThemes;

    [System.Obsolete]
    public void Starter()
    {
        AddSpeedForStaticPlatforms();
        SetStartValues();
    }

    public void ThemeChanger()
    {
        Change(SwitcherOfThemes);
    }

    private void Change(bool ThemeState)
    {
        if(ThemeState)
        {
            ThemeButtonText.text = "Dark";
            camera.backgroundColor = Color.white;
            ThemeButtonText.color = Color.black;
        }
        else
        {
            ThemeButtonText.text = "Light";
            camera.backgroundColor = Color.black;
            ThemeButtonText.color = Color.white;
        }
        SwitcherOfThemes = !SwitcherOfThemes;
    }

    [System.Obsolete]
    private void SetStartValues()
    {
        StartBtn.active = false;
        ThemeBtn.active = false;
        player.gravity = gravity;
        player.Speed = playerSpeed;
        player.verticalVelocity = verticalVelocity;
        player.JumpForce = jumpForce;
        PlatformScript.Speed = defaultPlatfromMovementSpeed;
    }
    private void AddSpeedForStaticPlatforms()
    {
        for (int i = 0; i < firstFourPlatforms.Length; i++)
        {
            if (i > 0) // Check for first platform couse it sude have lover speed
            {
                firstFourPlatforms[i].Speed = defaultPlatfromMovementSpeed;
            }
            else firstFourPlatforms[i].Speed = firstPlatformSpeed;
        }
    }
}
