using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeVictoria : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(-83.25f, 31.18f, -2034.8f);
    }
}
