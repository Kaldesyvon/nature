using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public void Appear()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }

    public void Dissapear()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
