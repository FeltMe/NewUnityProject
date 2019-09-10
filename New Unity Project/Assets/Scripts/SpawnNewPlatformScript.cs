using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewPlatformScript : MonoBehaviour
{
    public GameObject platformWithDimond;
    public GameObject platform;
    public GameObject PreviousGameObject;
    public CharacterController controller;

    void Update()
    {
        if(controller.isGrounded)
        {
            if(Random.Range(0, 200) > 50)
            {
                SpawnObject(platformWithDimond);
            }
            else SpawnObject(platform);
        }
    } 

    private void SpawnObject(GameObject @object)
    {
        Vector3 position = new Vector3(Random.Range(-13, 13), gameObject.transform.position.y, gameObject.transform.position.z);
        PreviousGameObject = Instantiate(@object, position, Quaternion.identity.normalized);
        }
    }
