using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject temp = other.gameObject;
        if (temp.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            temp.GetComponent<Movement>().movementSpeed += 3;
        }
    }
}
