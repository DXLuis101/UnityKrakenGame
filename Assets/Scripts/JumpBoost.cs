using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float multiplier = 1.5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            PlayerController.jumpForce *= multiplier;
            Destroy(gameObject);
        }
    }
}
