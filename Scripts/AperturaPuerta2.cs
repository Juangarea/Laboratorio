using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2 : MonoBehaviour
{
    public float speed;
    public float angle;
    public Vector3 direction;

    public bool puedeAbrir;

    public AudioClip openDoor;
    void Start()
    {
        angle = transform.eulerAngles.y;

    }

    void Update()
    {
        if (Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direction * speed);

        }

        if(Input.GetButtonDown("Fire1")&&puedeAbrir==true)
        {
            angle = 80;
            direction = Vector3.up;
        }

    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            puedeAbrir = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Capsule")
        {
            puedeAbrir = false;
        }

    }
}
