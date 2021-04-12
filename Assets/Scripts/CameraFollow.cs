using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform cameraTransform; // "public" = it will be exposed in the Unity editor inspector
     Transform cameraFollowTarget; // no public = private, it will NOT be exposed to the Unity editor inspector

    void Update() {
        
        cameraFollowTarget = gameObject.transform; // start camera following this object
        
        // every frame, move the camera to follow the target...
        cameraTransform.position = cameraFollowTarget.position + new Vector3( 0f, 1f, -7f ); 
    }
}
