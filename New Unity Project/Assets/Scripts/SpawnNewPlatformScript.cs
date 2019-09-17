using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNewPlatformScript : MonoBehaviour
{
    private const float MaxPlatfromSize = 12;
    private const float MinPlatfromSize = 9;
    private const float spawnPlatformWithDimond = 5;
    private const float limitsOfPlatformSpawn = 15;
    private const float SizeCoef = 0.97f;

    public GameObject platformWithDimond;
    public GameObject platform;
    public GameObject PreviousGameObject;
    public CharacterController controller;
    public Text Score;

    void Update()
    {
        if (controller.isGrounded)
        {
            if (Random.Range(0, 100) < spawnPlatformWithDimond)
            {
                SpawnObject(platformWithDimond);
            }
            else SpawnObject(platform);
        }
    }

    private void SpawnObject(GameObject @object)
    {
        if (int.Parse(Score.text) % 7 == 0)
        {
            if (@object.transform.localScale.x > MinPlatfromSize)
            {
                @object.transform.localScale = new Vector3(platform.transform.localScale.x * SizeCoef, 2, platform.transform.localScale.z * SizeCoef);
            }
        }
        Vector3 position = new Vector3(Random.Range(-limitsOfPlatformSpawn, limitsOfPlatformSpawn), gameObject.transform.position.y, gameObject.transform.position.z);
        PreviousGameObject = Instantiate(@object, position, Quaternion.identity.normalized);
    }
}