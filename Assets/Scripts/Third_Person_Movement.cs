using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Third_Person_Movement : MonoBehaviour
{
    public Transform spawnPoint;
    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBar;

    public CharacterController Controller;
    public Transform cam;

    public float speed = 5f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public bool hasObject;
    public bool isDead;
    public GameObject HUD;
    public GameObject Player;
    public GameObject GAME_OVER;

    void Start()
    {
        isDead=false;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        this.transform.position = spawnPoint.position;
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            Controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        if (currentHealth <= 0)
        {
            isDead = false;
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            this.transform.position = spawnPoint.position;
            isDead=true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeHealth(1);
        }

        if(isDead)
        {
            GAME_OVER.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
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
