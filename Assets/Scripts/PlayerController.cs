using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] static public float movementSpeed = 1f;
    static public float movementMultiplier = 10f;
    [SerializeField] static public float jumpForce = 200f;
    static public float jumpMultiplier = 10f;
    [SerializeField] static public float strength = 5f;
    static public float strengthMultiplier = 10f;
    [SerializeField] private Rigidbody _rb;

    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * jumpForce);
    }
}
