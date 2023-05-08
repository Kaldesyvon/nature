using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    PlayerController contorls;
    
    void Start()
    {
        contorls = new PlayerController();
    }

    private void OnEnable()
    {
        contorls.Player.Enable();
    }

    private void OnDisable()
    {
        contorls.Player.Disable();
    }
}
