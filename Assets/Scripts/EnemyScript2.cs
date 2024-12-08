using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
{
    public int health = 100;
    public int enemyValue;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            ScoreManager2.instance.ChangeScore(0, enemyValue, 0);
            Destroy(gameObject);
        }
    }
}
