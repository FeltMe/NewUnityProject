using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrementor : MonoBehaviour
{
    private const int platformColorChangeCoef = 20;

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
            var Temp_num = int.Parse(text.text) + 1; // increment 
            text.text = Temp_num.ToString();
            if (Temp_num % platformColorChangeCoef == 0)
            {
                materiaPlatformPrefab.color = Random.ColorHSV();
            }
        }
    }
}
