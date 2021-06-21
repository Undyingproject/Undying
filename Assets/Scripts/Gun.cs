using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 2f;
    public float range = 100f;
    public Transform player;
    public ParticleSystem particle;
    private AudioSource sound;

    private void Start()
    {
        var allSounds = gameObject.GetComponentsInChildren<AudioSource>();
        foreach(var sounds in allSounds)
            if(sounds.gameObject.transform.parent != null)
                sound = sounds;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        sound.Play();
        particle.Play();
        RaycastHit hit;
        if (Physics.Raycast(player.position, player.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy_Controller target = hit.transform.GetComponent<Enemy_Controller>();
            Minotaur_Controller targetMinotaur = hit.transform.GetComponent<Minotaur_Controller>();
            Boss_Controller targetBoss = hit.transform.GetComponent<Boss_Controller>();
            if (target != null)
                target.TakeDamage(damage);
            if (targetMinotaur != null)
                targetMinotaur.TakeDamage(damage);
            if (targetBoss != null)
                targetBoss.TakeDamage(damage);
        }
    }
}