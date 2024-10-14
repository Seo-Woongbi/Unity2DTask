using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAction : MonoBehaviour
{
    public GameObject Target;

    public float offsetX = 0f;
    public float offsetY = 0f;
    public float offsetZ = -10f;

    public float CameraSpeed = 10f;
    private Vector3 TargetPos;

    private void FixedUpdate()
    {
        TargetPos = new Vector3 (Target.transform.position.x + offsetX, Target.transform.position.y + offsetY, Target.transform.position.z + offsetZ);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
   
    }
}
