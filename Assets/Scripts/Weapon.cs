using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int ammo = 5;
    public float shootingTime = 0.3f;
    private float timeToReload;


    void Start()
    {
        timeToReload = shootingTime;
    }


    void Update()
    {
        if (ammo < 5)
        {
            timeToReload -= Time.deltaTime;
            //Debug.Log(Time.deltaTime);
            if (timeToReload <0)
            {
                Reload();
                Debug.Log("Reload");
            }
        }

        if (Input.GetButtonDown("Fire1")&& ammo!=0)
        {
            Shoot();
           
        }

       /* if(ammo == 0 && timeToReload < 0)
        {
            Reload();
            Debug.Log("Reload");
        }
*/
        //StartCoroutine(Reload()); 

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        ammo--;
    }

    /*public IEnumerator Reload()
    {
        yield return new WaitForSeconds(3f);
        ammo = 5;
    }
    */

    public void Reload()
    {
        ammo = 5;
        timeToReload = shootingTime;
    }
}
