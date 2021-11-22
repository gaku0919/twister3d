using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public List<GameObject> cameraList;

    public void OnPressedCameraButton(int cameraId) {
        if(cameraId<0 || cameraId >= cameraList.Count) {
            return;
        }
        for(int i=0; i<cameraList.Count;i++) {
            bool matched = i == cameraId ? true : false;
            cameraList[i].SetActive(matched);
        }
    }
}
