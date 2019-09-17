using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private const float defaultPlatfromMovementSpeed = 62.5f;
    private const float gravity = 120;
    private const float playerSpeed = 30f; 
    private const float verticalVelocity = 75; 
    private const float jumpForce = 50;
    private const float defaultPlatfromScale = 12f;

    public GameObject platformPrefab;
    public GameObject platformWithDimondPrefab;
    public MovePlatformScript PlatformScript;
    public PlayerMovement player;
    public GameObject StartBtn;
    public GameObject ThemeBtn;
    public Text ThemeButtonText;
    public Camera camera;
    public Text Score;
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
        if (ThemeState)
        {
            Score.color = Color.black;
            ThemeButtonText.text = "Dark";
            camera.backgroundColor = Color.white;
            ThemeButtonText.color = Color.black;
        }
        else
        {
            Score.color = Color.white; 
            ThemeButtonText.text = "Light";
            camera.backgroundColor = Color.black;
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
        player.speed = playerSpeed;
        player.verticalVelocity = verticalVelocity;
        player.jumpForce = jumpForce;
        player.cameraSpeedCoefficient = 3f;
        player.cameraXPositions = 3;
        PlatformScript.Speed = defaultPlatfromMovementSpeed;
        platformPrefab.transform.localScale = new Vector3(defaultPlatfromScale, platformPrefab.transform.localScale.y, defaultPlatfromScale);
        platformWithDimondPrefab.transform.localScale = new Vector3(defaultPlatfromScale, platformWithDimondPrefab.transform.localScale.y, defaultPlatfromScale);
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
