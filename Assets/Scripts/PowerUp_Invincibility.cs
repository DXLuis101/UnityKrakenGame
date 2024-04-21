using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Invincibility : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Debug.Log("Powerup Collected");
    }
}
