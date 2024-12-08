using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScriptTwo : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //Shooting code
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
