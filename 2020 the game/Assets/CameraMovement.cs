using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private void Update()
    { 
       // moves camera automatically (no movement A or D from user).
        transform.Translate(.00f, 0, 0);
    }
}