﻿using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 2f;
    public float range = 100f;
    public Transform player;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.position, player.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy_Controller target = hit.transform.GetComponent<Enemy_Controller>();
            if (target != null)
                target.TakeDamage(damage);
        }
    }
}