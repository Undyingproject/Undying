using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public Third_Person_Movement player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && player.hasObject)
        {
            gameObject.SetActive(false);
        }
    }
}
