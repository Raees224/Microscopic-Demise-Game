using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthBar;
    [SerializeField] GameObject gameOverScreen;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //Debug.Log("You Right clicked. You took 20 damage");
            TakeDamage(20);
        }

        //if (currentHealth == 0)
        //{
        //    gameOverMenu();
        //}
    }
    

   private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Enemy"))
       {
           //Debug.Log("The enemy touched you. You took 20 damage");
           TakeDamage(20);
       }
       
       if (currentHealth == 0)
       {
           gameOverMenu();
       }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void gameOverMenu()
    {
        gameOverScreen.SetActive(true);
    } 
}
