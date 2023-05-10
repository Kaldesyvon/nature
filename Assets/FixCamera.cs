using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamera : MonoBehaviour
{
    Vector3 cameraPosition;
    Quaternion cameraRotation;
    public new Camera camera;
    // Start is called before the first frame update
    void Awake()
    {
        //cameraPosition = camera.transform.position;
        //cameraRotation = camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(9.971848f, 21.41265f, -31.6289f);
        //camera.transform.rotation = cameraRotation;
    }
}
