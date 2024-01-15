using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPuerta2 : MonoBehaviour
{
    public Animator laPuerta2;
    private void OnTriggerEnter(Collider other)
    {
        laPuerta2.Play("abrir2");

    }
}

