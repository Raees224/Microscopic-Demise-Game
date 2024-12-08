using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript2 : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager2.instance.ChangeScore(coinValue, 0, 0);
            Destroy(gameObject);
        }
    }
}
