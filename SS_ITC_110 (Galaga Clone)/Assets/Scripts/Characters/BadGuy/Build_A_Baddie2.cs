using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie2 : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;
    public GameObject firePoint;
    public GameObject bullet;
    bool canShoot = true;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
    }

    private void Update()
    {
        if (canShoot)
        {
            StartCoroutine(ShootObject());
        }    
    }

    public IEnumerator ShootObject()
    {
        canShoot = false;

        GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation) as GameObject;

        // get Rigidbody2D component of instantiated Bullet and control
        Rigidbody2D tempRigidBody = newBullet.GetComponent<Rigidbody2D>();
        tempRigidBody.AddForce(-transform.up * 1500.0f);

        yield return new WaitForSeconds(5.0f);

        canShoot = true;
        Destroy(newBullet, 2.0f);
    }
}
