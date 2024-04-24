using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Transform objetivoASeguir;
    public float velocidadCamara = 15f;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = objetivoASeguir.position + offset;
    }
}
