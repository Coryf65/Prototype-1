using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject objectToFollow = null;

    private Vector3 cameraOffset = new Vector3(0, 7, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // follow the Object, the player
        // Camera Position = Players Position        
        transform.position = objectToFollow.transform.position + cameraOffset; // adding an offset
    }
}
