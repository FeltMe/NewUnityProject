using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject StartBtn;
    public GameObject ThemeBtn;
    public MovePlatformScript platformPrefab;
    public MovePlatformScript platformPrefabWithDimond;
    public PlayerMovement player;
    public GameObject RestartBtn;
    public Text Score;


    private void SpawnDefaultFourPlatforms()
    {
        Instantiate(platformPrefab, new Vector3(0, 25, 25), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 104), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 158), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 213), Quaternion.identity);
    }

    private void SetButtons()
    {
        StartBtn.SetActive(true);
        ThemeBtn.SetActive(true);
        RestartBtn.SetActive(false);
        Score.text = "0";
    }

    private void SetPlayerValues()
    {
        player.verticalVelocity = 0;
        player.transform.position = new Vector3(0, 27.3f, 24.38f);
        player.GetComponent<CharacterController>().enabled = true;
    }


    public void GameRestart()
    {
        SpawnDefaultFourPlatforms();
        SetButtons();
        SetPlayerValues();
    }
    private void OnTriggerEnter(Collider collider)
    {
        RestartBtn.SetActive(true);
        SetValuesToZero();
        DeletePlatforms();
        SetPlatformScales();
    }

    private void SetValuesToZero()
    {
        player.gravity = 0;
        player.speed = 0; 
        player.verticalVelocity = 0;
        player.jumpForce = 0;
        platformPrefab.Speed = 0;
        player.cameraXPositions = 0;
        player.cameraSpeedCoefficient = 0;
        player.GetComponent<CharacterController>().enabled = false;
    }

    private void SetPlatformScales()
    {
        platformPrefab.transform.localScale = new Vector3(12, 2, 12);
        platformPrefabWithDimond.transform.localScale = new Vector3(12, 2, 12);
    }

    private void DeletePlatforms()
    {
        var platforms = GameObject.FindGameObjectsWithTag("Platform");
        foreach (var item in platforms)
        {
            Destroy(item);
        }
    }
}
