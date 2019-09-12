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

    public void GameRestart()
    {
        StartBtn.SetActive(true);
        ThemeBtn.SetActive(true);
        RestartBtn.SetActive(false);
        Instantiate(platformPrefab, new Vector3(0, 25, 25), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 104), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 158), Quaternion.identity);
        Instantiate(platformPrefab, new Vector3(0, 25, 213), Quaternion.identity);
        Debug.Log(player.transform.position);
        player.transform.position.Set(0, 27.3f, 24.38f); //todo
        Debug.Log(player.transform.position);
        player.verticalVelocity = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        RestartBtn.SetActive(true);
        player.gravity = 0;
        player.Speed = 0;
        player.verticalVelocity = 0;
        player.JumpForce = 0;
        platformPrefab.Speed = 0;
        Score.text = "0";
        platformPrefab.transform.localScale = new Vector3(12, 2, 12);
        platformPrefabWithDimond.transform.localScale = new Vector3(12, 2, 12);
        var platforms = GameObject.FindGameObjectsWithTag("Platform(Clone)");
        foreach (var item in platforms) // todo
        {
            Destroy(item);
        }
    }
}
