using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossScript : MonoBehaviour
{
    public int health = 2400;
    public int currentHealth;

    public int enemyBossValue;

    public HealthBarScript healthBar;
    public GameObject BossHealthBar;

    void Start()
    {
        healthBar.SetMaxHealth(health);            //Sets healthbar to health value
        currentHealth = health;                    //currenthealth equals health value
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
            //Debug.Log("You Right clicked. You took 20 damage");
            //TakeDamage(20);
        //}
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            ScoreManager.instance.ChangeScore(0, enemyBossValue, 0);
            Destroy(gameObject);
            BossHealthBar.SetActive(false);
        }
    }
}
