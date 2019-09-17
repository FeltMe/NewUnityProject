using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlatformScript : MonoBehaviour
{
    private GameObject FinishObject;
    public float Speed;

    private void Start()
    {
        FinishObject = GameObject.FindGameObjectWithTag("Finish");
    }
    void Update()
    {
        if ((FinishObject is null) != true)
        {
            if (gameObject.transform.position.z > FinishObject.transform.position.z)
            {
                gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
            }
            else
            {
                Destroy(gameObject);
                GC.Collect(0);
            }
        }
    }
   
}
