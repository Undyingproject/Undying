using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Third_Person_Movement player;
    public Transform respawnPoint;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.Controller.enabled = false;
            player.transform.position = respawnPoint.transform.position;
            player.Controller.enabled = true;
        }
    }
}
