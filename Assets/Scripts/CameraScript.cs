using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Antonio;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Antonio.transform.position.x;
        transform.position = position;  
    }
}
