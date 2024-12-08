using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Player"))
       {
           ScoreManager.instance.ChangeScore(coinValue, 0, 0);
           Destroy(gameObject);
       }
    }
}
