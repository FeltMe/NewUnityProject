using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public GameObject ObjectToMove { get; set; }
    public GameObject FinishObject { get; set; }
    public float MoveTime { get; set; }

    void Start()
    {
        
    }

    void Update()
    {
        if(ObjectToMove.transform.position != FinishObject.transform.position)
        {
            ObjectToMove.transform.
        }
    }
}
