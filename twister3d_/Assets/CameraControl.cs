using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    private GameObject mainCamera;
    private GameObject playerObject;
    public float rotateSpeed = 2.0f;
    
    void Start()
    {
        mainCamera = Camera.main.gameObject;
        playerObject = GameObject.Find("unitychan");
    }

    
    void Update()
    {
        rotateCamera();
    }

    private void rotateCamera() {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.right, angle.y);
    }
}