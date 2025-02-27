﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public int MaxAmmo = 6;
    public int CurrentAmmo = 6;

    public GameObject bulletPrefab;
    //public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    //public Transform casingExitLocation;


    public float shotPower = 100f;

    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    void Reload()
    {
        CurrentAmmo = MaxAmmo;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && CurrentAmmo > 0)
        {
            GetComponent<Animator>().SetTrigger("Fire");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    void Shoot()
    {
        GameObject bullet;
        CurrentAmmo--;

        GameObject tempFlash;
        bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);

        RaycastHit HitInfo;
        bool HasHitSomething = Physics.Raycast(barrelLocation.position, barrelLocation.forward, out HitInfo, 100);

        Destroy(tempFlash, 0.5f);
         //Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation).GetComponent<Rigidbody>().AddForce(casingExitLocation.right * 100f);
       
    }

    void CasingRelease()
    {
        //GameObject casing;
        //casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        //casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        //casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
    }


}
