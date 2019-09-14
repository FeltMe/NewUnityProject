using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{

    public PlayerMovement player;
    public MovePlatformScript platform;
    public GameObject platformPrefab;
    public GameObject RestartBtn;

    private void Start()
    {
        RestartBtn.SetActive(false);
    }
}