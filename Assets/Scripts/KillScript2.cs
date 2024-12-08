using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript2 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthBar;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject gameOverScreen;
    //public MovementScript movement;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("KillFloor"))
        {
            TakeDamage(20);
            gameObject.transform.position = spawnPoint.position;
            //movement.enabled = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("The enemy touched you. You took 20 damage");
            TakeDamage(20);
        }

        if ((currentHealth == 0) && collision.transform.CompareTag("Enemy"))            //If player health reaches Zero and they touch an enemy
        {
            gameOverMenu();                                                           //Run function
            //gameObject.transform.position = spawnPoint.position;                        //Respawns the player at the respawnpoint
            //currentHealth = 100;                                                        //Sets the healthbar to 100 after respawning
            //healthBar.SetHealth(currentHealth);                                         //Resets the sliders of the health
        }

        if ((currentHealth == 0) && collision.transform.CompareTag("KillFloor"))        //If player health reaches Zero and they touch the killfloor
        {
            gameOverMenu();
            //gameObject.transform.position = spawnPoint.position;                        //Respawns the player at the respawnpoint
            //currentHealth = 100;                                                        //Sets the healthbar to 100 after respawning 
            //healthBar.SetHealth(currentHealth);                                         //Resets the sliders of the health
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void gameOverMenu()
    {
        gameOverScreen.SetActive(true);           //When run, this will make this game object active
    }
}
