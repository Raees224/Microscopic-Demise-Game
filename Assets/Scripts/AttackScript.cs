using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] bullets;

    private MovementScript movement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        movement = GetComponent<MovementScript>();
    }

    private void Update()
    {
        //if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && movement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        cooldownTimer = 0;

        bullets[0].transform.position = FirePoint.position;
        //bullets[0].GetComponent<BulletScript>().SetDirection(Mathf.Sign(transform.localScale.x));
    }



}

