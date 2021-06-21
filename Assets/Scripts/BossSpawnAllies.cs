using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnAllies : MonoBehaviour
{
    public GameObject[] allies;
    private float health;
    public float healthToSpawn;
    private bool didSpawn = true;
    void Start()
    {
        foreach (var ally in allies)
            ally.SetActive(false);
    }

    void Update()
    {
        Boss_Controller me = gameObject.GetComponent<Boss_Controller>();
        health = me.health;
        if (health <= healthToSpawn && didSpawn)
        {
            foreach (var ally in allies)
                ally.SetActive(true);
            didSpawn = false;
        }
    }
}
