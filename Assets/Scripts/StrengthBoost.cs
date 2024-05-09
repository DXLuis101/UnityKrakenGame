using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthBoost : MonoBehaviour
{
    public float multiplier = 1.5f;
    public float duration = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            PlayerController.strength *= multiplier;

            Destroy(gameObject);
        }
    }
}
