using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakbyedynamite : MonoBehaviour
{
    public Third_Person_Movement player;
    public bool level;
    public GameObject mur;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && player.hasObject)
        {
            mur.SetActive(false);
        }
    }
}
