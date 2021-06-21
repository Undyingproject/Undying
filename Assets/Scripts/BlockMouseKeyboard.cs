using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMouseKeyboard : MonoBehaviour
{
    public GameObject dialog;
    public GameObject player;

    private void Start()
    {
        player.SetActive(false);
    }
    private void Update()
    {
        if (dialog == null)
            player.SetActive(true);

    }
}
