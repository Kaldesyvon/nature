using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject from;
    public GameObject to;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("am in");

            Vector3 portal = player.transform.position - transform.position;

            //float dotProduct = Vector3.Dot(transform.forward, portal);

            player.transform.position = to.transform.position + portal;
        }
    }
}
