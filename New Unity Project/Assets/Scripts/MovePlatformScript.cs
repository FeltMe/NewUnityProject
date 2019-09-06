using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                Debug.Log("Destroy");
                Destroy(gameObject);
            }
        }
        else Debug.Log("Fin obj null");
        
    }
}
