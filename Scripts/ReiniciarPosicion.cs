using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarPosicion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position= new Vector3(10.33f, 1.14f, -30.1f);
    }

}
