using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningWeapon : Weapon
{
    [SerializeField] public float lifetime = 2f;
    private float lightningTimer = 0f;
    public GameObject lightningPrefab;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (lightningTimer >= 1 / attacksPerSecond)
            {
                Shoot();
                lightningTimer = 0f;
            }
        }

        if (lightningTimer < 1 / attacksPerSecond) lightningTimer += Time.deltaTime;

    }

    void Shoot()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        Vector3 shootDirection = (mousePosition - transform.position).normalized;
        GameObject lightningClone = Instantiate(lightningPrefab, transform.position, Quaternion.identity);
        Destroy(lightningClone, lifetime);

        lightningClone.GetComponent<Lightning>().damage = damage;
        lightningClone.GetComponent<Lightning>().shootDirection = shootDirection;
        Debug.Log(shootDirection);
    }
}
