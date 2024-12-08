using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    bool playerDetected;

    //public int sceneToLoad;

    [SerializeField] GameObject KeyTextOne;
    [SerializeField] GameObject KeyTextTwo;
    [SerializeField] GameObject LevelCompleteScreen;


    // Start is called before the first frame update
    void Start()
    {
        playerDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerDetected && (Input.GetKeyDown(KeyCode.Z))) 
        {
            if((!GameObject.FindWithTag("Enemy")))
            {
                LevelCompleteScreen.SetActive(true);
                //SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;

            if (GameObject.FindWithTag("Enemy"))
            {
                KeyTextTwo.SetActive(true); //If there are still enemies on screen then a message should pop up telling you that  
            }

            else if(!GameObject.FindWithTag("Enemy"))
            {
                KeyTextOne.SetActive(true); //If all the enemies are destroyed then press the "Z" key to go to the next screen 
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = false;
            KeyTextTwo.SetActive(false);
            KeyTextOne.SetActive(false);
        }
    }
}
