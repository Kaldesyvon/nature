using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{



    [Range(0f, 4f)]
    public float red;
    [Range(0f, 4f)]
    public float green;
    [Range(0f, 4f)]
    public float blue;


    void Start()
    {

    }

    void Update()
    {
        // renderrer.material.SetColor("Color", new ColorChanger(red, green, blue));
    }
}
