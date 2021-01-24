using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        // moving a 20 m/s
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}