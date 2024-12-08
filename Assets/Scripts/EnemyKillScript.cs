using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKillScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthBar;
    [SerializeField] Transform spawnPoint;     //Declare a transform component

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("The enemy touched you. You took 20 damage");
            TakeDamage(20);
        }

        if (currentHealth == 0)                                             //If player health reaches Zero
        {
                gameObject.transform.position = spawnPoint.position;        //Respawns the player at the respawnpoint
                currentHealth = 100;                                        //Sets the healthbar to 100 after respawning 
                healthBar.SetHealth(currentHealth);                         //Resets the sliders of the health
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
