using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if (Camera.main.aspect >= 1)
        //{
        //    //Camera position for landscape mode
        //    transform.position = new Vector3(0.0f, 16.0f, -2.5f);
        //}
        //else
        {
            //Camera position for portrait mode
            transform.position = new Vector3(0.0f, 32, -7.5f);
        }
    }
}
