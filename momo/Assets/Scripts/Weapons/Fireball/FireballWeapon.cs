using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballWeapon : Weapon
{
/*    [SerializeField] private float damage;
    [SerializeField] private float attacksPerSecond = 2;*/
    [SerializeField] private float velocity;
    [SerializeField] public float lifetime = 2f;
    private float fireballTimer = 0f;
    public GameObject fireballPrefab;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (fireballTimer >= 1 / attacksPerSecond)
            {
                Shoot();
                fireballTimer = 0f;
            }
        }

        if (fireballTimer < 1 / attacksPerSecond) fireballTimer += Time.deltaTime;

    }

    void Shoot()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        // Calculate the direction to shoot towards
        Vector3 shootDirection = (mousePosition - transform.position).normalized;

        // Instantiate the fireball prefab
        GameObject fireballClone = Instantiate(fireballPrefab, transform.position, Quaternion.identity);

        // Rotate the fireball to point towards the mouse cursor
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        fireballClone.transform.rotation = Quaternion.Euler(0, 0, angle);

        // Set the fireball's velocity
        fireballClone.GetComponent<Rigidbody2D>().velocity = fireballClone.transform.right * velocity;

        // Set the fireball's lifetime
        Destroy(fireballClone, lifetime);

        // Set the fireball's damage
        fireballClone.GetComponent<Fireball>().damage = damage;
    }
}
