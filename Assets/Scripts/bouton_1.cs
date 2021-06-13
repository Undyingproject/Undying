using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton_1 : MonoBehaviour
{
    public Third_Person_Movement player;
    public GameObject Object;
    public GameObject Object2;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Object.SetActive(false);
            Object2.SetActive(false);
        }
    }
}