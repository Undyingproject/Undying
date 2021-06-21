using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropKey : MonoBehaviour
{
    public GameObject key;
    public Boss_Controller boss;
    private bool spawnKey = true;
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Boss_Controller boss = gameObject.GetComponent<Boss_Controller>();
        if(boss.health<=3 && spawnKey)
        {
            key.SetActive(true);
            key.transform.position = boss.transform.position;
            spawnKey = false;
        }
    }
}
