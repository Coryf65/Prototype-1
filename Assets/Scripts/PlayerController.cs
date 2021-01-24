using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float speed = 30f;
    [SerializeField] private float horsePower = 0f;
    [SerializeField] private float turnSpeed = 25f;
    private float horizontalInput = 0f;
    private float verticalInput = 0f;
    private Rigidbody playerRb = null;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is useful for physics
    void FixedUpdate()
    {
        // getting player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // moving a 20 m/s
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // do not need to use time for this since it is a force
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput); // switched to use Local Coordinates not global
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}