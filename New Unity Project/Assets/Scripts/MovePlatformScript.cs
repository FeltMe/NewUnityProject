using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformScript : MonoBehaviour
{
    public GameObject FinishObject;
    public float Speed;
    void Update()
    {
        if(gameObject.transform.position.z > FinishObject.transform.position.z)
        {
            gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
        }
        else
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }
}
