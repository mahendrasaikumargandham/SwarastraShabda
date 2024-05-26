using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 50f;
    public Transform player;
    float xRotate = 0f;
    
    void LateUpdate()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotate -= y;
        xRotate = Mathf.Clamp(xRotate, -50f, 50f);
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        player.Rotate(Vector3.up * x);
    }
}
