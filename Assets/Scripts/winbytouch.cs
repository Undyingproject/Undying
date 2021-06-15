using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winbytouch : MonoBehaviour
{
    public Third_Person_Movement player;
    public bool level;
    public GameObject WinMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            level = true;
        }
        if(level == true)
        {
            WinMenu.SetActive(true);
            Time.timeScale= 0f;
        }
    }
}
