using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie1 : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;
    public GameObject itemtoSpawn;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.GetComponent<Bullet>().Despawn();
            Instantiate(itemtoSpawn, this.transform.position, Quaternion.identity);
        }
    }
}
