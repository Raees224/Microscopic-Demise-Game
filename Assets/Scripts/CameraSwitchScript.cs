using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScript : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CameraSwitch1"))
        {

            Time.timeScale = 0f;
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
        }

        //else if (Input.GetButtonDown("CameraSwitch1") && cameraOne.SetActive(false))
        //{
            //Time.timeScale = 1f;
            //cameraOne.SetActive(false);
            //cameraTwo.SetActive(true);
        //}

        if (Input.GetButtonDown("CameraSwitch2"))
        {
            Time.timeScale = 1f;
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
        }
    }
}
