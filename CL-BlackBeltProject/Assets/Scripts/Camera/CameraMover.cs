using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform targetPosition;
    public MoveCamera moveCamera;
    private void OnEnable()
    {
        //setting the camera position to targetPosition
        moveCamera.cameraPosition = targetPosition;
    }
}
