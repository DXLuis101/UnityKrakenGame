using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [SerializeField] ParticleSystem speedParticle = null;
    public float multiplier = 1.5f;
    public float duration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            PlayerController.movementSpeed *= multiplier;
            speedParticle.Play();
            Destroy(gameObject);
        }
    }
}
