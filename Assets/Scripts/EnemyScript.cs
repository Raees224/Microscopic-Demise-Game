using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health = 100;

    public int enemyValue;

    //public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            //Perish();
            ScoreManager.instance.ChangeScore(0, enemyValue, 0);
            Destroy(gameObject);
        }
    }

    /*
    void Perish()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    */
}
