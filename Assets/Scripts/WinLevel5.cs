using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel5 : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject winMenu;

    private void Update()
    {
        if(enemies[0] == null &&
            enemies[1] == null &&
            enemies[2] == null &&
            enemies[3] == null &&
            enemies[4] == null &&
            enemies[5] == null &&
            enemies[6] == null &&
            enemies[7] == null)
        {
            winMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
