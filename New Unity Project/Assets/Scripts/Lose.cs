using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y < 25)
        {
            Debug.Log("Lose");
        }
    }
}
