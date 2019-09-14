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

    public MovePlatformScript PlatformScript;
    public PlayerMovement player;
    public GameObject StartBtn;
    public GameObject ThemeBtn;
    public Text ThemeButtonText;
    private new Camera camera;

    private bool SwitcherOfThemes;

    public Camera Camera { get => camera; set => camera = value; }

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
            Camera.backgroundColor = Color.white;
            ThemeButtonText.color = Color.black;
        }
        else
        {
            ThemeButtonText.text = "Light";
            Camera.backgroundColor = Color.black;
            ThemeButtonText.color = Color.white;
        }
        SwitcherOfThemes = !SwitcherOfThemes;
    }

    [System.Obsolete]
    private void SetStartValues()
    {
        StartBtn.SetActive(false);
        ThemeBtn.SetActive(false);
        player.gravity = gravity;
        player.Speed = playerSpeed;
        player.verticalVelocity = verticalVelocity;
        player.JumpForce = jumpForce;
        PlatformScript.Speed = defaultPlatfromMovementSpeed;
    }
    private void AddSpeedForStaticPlatforms()
    {
        var firstFourPlatforms = GameObject.FindGameObjectsWithTag("Platform");
        
        for (int i = 0; i < firstFourPlatforms.Length; i++)
        {
            var s = firstFourPlatforms[i].GetComponent<MovePlatformScript>();
            s.Speed = defaultPlatfromMovementSpeed;
        }
    }
}
