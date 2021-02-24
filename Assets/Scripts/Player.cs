using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public int maxHealth = 20;
	public int currentHealth;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(1);
		}

		if (Input.GetKeyDown(KeyCode.T))
		{
			TakeHealth(1);
		}
	}

	public void TakeDamage(int damage)
	{
		if (currentHealth > 0)
		{
			currentHealth -= damage;
		}
		healthBar.SetHealth(currentHealth);
	}

	public void TakeHealth(int addpv)
	{
		if (currentHealth < 20 && currentHealth > 0)
		{
			currentHealth += addpv;	
		}

		healthBar.SetHealth(currentHealth);
	}
}
