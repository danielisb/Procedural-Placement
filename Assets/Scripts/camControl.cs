using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    public Transform barrelElv;

    float min = -20;
    float max = 6.5f;
    float speedBarrel = 8.0f;
    float elevationx = 0;
    float elevationy;
    float elevationz;

    void Start() {}

    void Update()
    {
        moveCamera();
    }
    void moveCamera()
    {
        // horizontal rotation control
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * speedBarrel, 0.0f);
        // barrel elevation control
        float v = -Input.GetAxis("Vertical") * speedBarrel;
        elevationx = Mathf.Clamp(elevationx+v,min,max);
        barrelElv.localRotation = Quaternion.Euler(elevationx, elevationy, elevationz);
    }
}
