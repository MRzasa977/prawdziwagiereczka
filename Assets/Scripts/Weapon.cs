using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int ammo = 5;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1")&& ammo!=0)
        {
            Shoot();
        }


    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        ammo--;
    }
}
