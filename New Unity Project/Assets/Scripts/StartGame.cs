using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public MovePlatformScript[] firstFourPlatforms;
    public MovePlatformScript PlatformScript;
    public PlayerMovement player;
    public GameObject StartBtn;
    public new Camera camera;
    public Text ThemeButtonText;
    public GameObject ThemeBtn;

    private bool Switcher;

    [System.Obsolete]
    public void Starter()
    {
        for (int i = 0; i < firstFourPlatforms.Length; i++)
        {
            if(i > 0)
            {
                firstFourPlatforms[i].Speed = 52.5f;
            }
            else firstFourPlatforms[i].Speed = 25.5f;
        }
        player.gravity = 100;
        player.Speed = 35;
        player.verticalVelocity = 75;
        player.JumpForce = 50;
        PlatformScript.Speed = 52.5f;
        StartBtn.active = false;
        ThemeBtn.active = false;

    }

    public void ThemeChanger()
    {
        Change(Switcher);
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
        Switcher = !Switcher;
    }

}
