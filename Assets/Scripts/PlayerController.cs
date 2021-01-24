using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horsePower = 0f;
    [SerializeField] private float turnSpeed = 25f;
    private float horizontalInput = 0f;
    private float verticalInput = 0f;
    private Rigidbody playerRb = null;
    [SerializeField] GameObject centerOfMass = null;
    [SerializeField] TextMeshProUGUI spedoText = null;
    private const float toMph = 2.237f;
    private const float toKph = 3.6f;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
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
        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower); // switched to use Local Coordinates not global
        //playerRb.centerOfMass = 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        SetVehicleSpedometer();
    }

    void SetVehicleSpedometer()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * toMph);
        spedoText.SetText($"Speed: {speed} mph");
    }
}