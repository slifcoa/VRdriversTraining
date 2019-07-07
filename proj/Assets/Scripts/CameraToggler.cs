using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggler : MonoBehaviour
{
    public Camera m_dashCam;
    public Camera m_thirdPersonCam;

    private void Start()
    {
        m_dashCam.enabled = true;
        m_thirdPersonCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (m_dashCam.enabled)
            {
                m_thirdPersonCam.enabled = true;
                m_dashCam.enabled = false;
            } else
            {
                m_dashCam.enabled = true;
                m_thirdPersonCam.enabled = false;
            }
        }        
    }
}
