using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_Person_Movement : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBar;

    public CharacterController Controller;
    public Transform cam;

    public float speed = 5f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public bool hasObject;
    public bool isAlive;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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
        if (maxHealth <= 0)
        {
            isAlive = false;
            Destroy(GetComponent<Third_Person_Movement>());
        }

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
