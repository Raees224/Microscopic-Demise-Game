using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpcubeScript : MonoBehaviour
{
    //bool playerDetected;

    [SerializeField] GameObject HelpText;

    // Start is called before the first frame update
    void Start()
    {
        //playerDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
       //if (playerDetected && (Input.GetKeyDown(KeyCode.Z)))
       //{
       //    if ((!GameObject.FindWithTag("Enemy")))
       //    {
       //        SceneManager.LoadScene(sceneToLoad);
       //    }
       //}
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //playerDetected = true;
            HelpText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //playerDetected = false;
            HelpText.SetActive(false); 
        }
    }
}
