using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject RestartBtn;
    void Start()
    {
        RestartBtn.SetActive(false);
    }
}
