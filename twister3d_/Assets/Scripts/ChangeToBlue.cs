using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToBlue : MonoBehaviour
{
    void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    void OnCollisionExit(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
