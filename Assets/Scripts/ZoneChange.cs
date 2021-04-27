using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChange : MonoBehaviour
{
    public Third_Person_Movement player;
    public GameObject Saphyria;
    public GameObject Nuage;

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Saphyria.SetActive(true);
            yield return new WaitForSeconds(2);
            Saphyria.SetActive(false);
        }
    }
}