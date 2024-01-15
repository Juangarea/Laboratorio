using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPuerta : MonoBehaviour
{
    public Animator laPuerta;
    private void OnTriggerEnter(Collider other)
    {
        laPuerta.Play("abrir");

    }
}
