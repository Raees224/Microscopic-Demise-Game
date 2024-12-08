using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch2Script : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;

    public GameObject healthbarUI;
    public GameObject pointsUI;
    public GameObject totalPointsUI;
    public GameObject pauseUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CameraSwitch1"))
        {

            Time.timeScale = 0f;
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
            healthbarUI.SetActive(false);
            pointsUI.SetActive(false);
            totalPointsUI.SetActive(false);
            pauseUI.SetActive(false);
        }

        if (Input.GetButtonDown("CameraSwitch2"))
        {
            Time.timeScale = 1f;
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
            healthbarUI.SetActive(true);
            pointsUI.SetActive(true);
            totalPointsUI.SetActive(true);
            pauseUI.SetActive(true);
        }

        //else if (Input.GetButtonDown("CameraSwitch1") && cameraOne.SetActive(false))
        //{
        //Time.timeScale = 1f;
        //cameraOne.SetActive(false);
        //cameraTwo.SetActive(true);
        //}
    }
}
