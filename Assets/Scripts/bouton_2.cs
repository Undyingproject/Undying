using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton_2 : MonoBehaviour
{
    public bool test1 = false;
    public bool test2 = false;

    public Third_Person_Movement player;
    public GameObject Object;
    public GameObject Object2;
    public GameObject Object3;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Button_1")
        {
            Object.SetActive(false);
            test1 = true;
        }
        if (other.gameObject.tag == "Button_2")
        {
            Object2.SetActive(false);
            test2 = true;
        }
    }

    void Update()
    {
        if (test1 && test2)
        {
            Object3.SetActive(false);
        }
    }
}
