using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFOV : MonoBehaviour {
    
    float m_FieldOfView;

    void Start() {

        m_FieldOfView = 60.0f;
    }

    void Update() {

        if (Input.GetKeyDown("u"))
            m_FieldOfView = 60.0f;
        if (Input.GetKeyDown("i"))
            m_FieldOfView = 16.0f;
        if (Input.GetKeyDown("o"))
            m_FieldOfView = 4.0f;
        
        Camera.main.fieldOfView = m_FieldOfView;
    }
}
