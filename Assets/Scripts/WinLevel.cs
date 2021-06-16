using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WinLevel : MonoBehaviour
{
    public Third_Person_Movement player;
    public bool level;
    public GameObject WinMenu;
    public VideoPlayer video;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && player.hasObject)
        {
            video.Play();
            level = true;
        }
        if(level == true)
        {
            WinMenu.SetActive(true);
            Time.timeScale= 0f;
        }
    }
}
