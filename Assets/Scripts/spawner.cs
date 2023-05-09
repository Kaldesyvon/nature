using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject bullet;
    PlayerController controls;
    public GameObject avatar;
    int idx = 0;

    private void Awake()
    {
        controls = new PlayerController();
    }

    void Update()
    {
        if(controls.keyboard.Fire.ReadValue<float>() == 1)
        {
            var instance = Instantiate(bullet, (transform.position = new Vector3(0,-0.2f, 0.5f)),
                Quaternion.Euler(avatar.transform.eulerAngles.x, avatar.transform.eulerAngles.y, 90));
            instance.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 3000);
        }
    }

    private void OnEnable()
    {
        controls.keyboard.Enable();
    }

    private void OnDisable()
    {
        controls.keyboard.Disable();
    }
}