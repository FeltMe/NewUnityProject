using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewPlatformScript : MonoBehaviour
{
    public GameObject platform;
    public GameObject PreviousGameObject;   

    void Start()
    {

    }

    void Update()
    {
        if(PreviousGameObject.transform.position.z < 382)
        {
            SpawnObject(platform);
            PreviousGameObject = platform;
        }
    } 

    private void SpawnObject(GameObject @object)
    {
        Vector3 position = new Vector3(Random.Range(-17, 17), gameObject.transform.position.y, gameObject.transform.position.z);
        Instantiate(@object, position, Quaternion.identity.normalized);
    }
}
