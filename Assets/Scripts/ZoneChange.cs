using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChange : MonoBehaviour
{
    public Third_Person_Movement player;
    public bool mmmh = false;
    public GameObject Saphyria;
    public GameObject Nuage;

    public GameObject walou;
    public GameObject wala;

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (walou.gameObject.tag == "Player" && !mmmh)
        {
            mmmh = true;
            Saphyria.SetActive(true);
            yield return new WaitForSeconds(2);
            Saphyria.SetActive(false);
        }
    }

    IEnumerator OnTriggerEnter2(Collider other)
    {
        if (wala.gameObject.tag == "Player" && mmmh)
        {
            mmmh = false;
            Nuage.SetActive(true);
            yield return new WaitForSeconds(2);
            Nuage.SetActive(false);
        }
    }
}
