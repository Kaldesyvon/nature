using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggiRotation : MonoBehaviour
{

    float rotationSpeed = 5f;

    public GameObject doggi;
    public Camera camera;

    private bool shouldRotate = false;

    public void DoggiRotateEnable() {
        shouldRotate = true;
    }

    public void DoggiRotateDisable()
    {
        shouldRotate = false;
    }

    private void Update()
    {
        if (shouldRotate)
        {
            Vector3 targetDirection = camera.transform.position - doggi.transform.position;

            targetDirection.y = 0f;

            Vector3 newDirection = Vector3.RotateTowards(
                doggi.transform.forward,
                targetDirection,
                rotationSpeed * Time.deltaTime,
                0f);

            doggi.transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}

