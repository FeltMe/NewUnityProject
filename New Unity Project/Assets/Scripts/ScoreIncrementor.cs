using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrementor : MonoBehaviour
{
    private CharacterController controller;
    public Text text;
    public Material materiaPlatformPrefab;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            var Temp_num = int.Parse(text.text) + 1;
            text.text = Temp_num.ToString();
            if (Temp_num % 20  == 0)
            {
                materiaPlatformPrefab.color = Random.ColorHSV();
            }
        }
    }
}
