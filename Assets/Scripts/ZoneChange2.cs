using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChange2 : MonoBehaviour
{
    public Third_Person_Movement player;
    public GameObject Saphyria;
    public GameObject Nuage;

    IEnumerator OnTriggerEnter2(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Nuage.SetActive(true);
            yield return new WaitForSeconds(2);
            Nuage.SetActive(false);
        }
    }
}