using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        // 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}