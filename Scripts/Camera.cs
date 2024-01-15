using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    public float mouseSensitivity = 80;
    public Transform playerMovement;

    float xRotation = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation,-90f, 90);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);


        playerMovement.Rotate(Vector3.up * mouseX);
            
    }
}
