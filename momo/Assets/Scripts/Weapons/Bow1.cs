using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow1 : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float velocity;
    [SerializeField] private float attacksPerSecond;
    [SerializeField] public float arrowLifetime = 2f;
    private float arrowTimer = 0f;
    public GameObject arrowPrefab;

    void Update()
    {
        // Check for mouse input
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in world coordinates
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            // Calculate the direction to shoot towards
            Vector3 shootDirection = (mousePosition - transform.position).normalized;

            // Instantiate the arrow prefab
            GameObject arrowClone = Instantiate(arrowPrefab, transform.position, Quaternion.identity);

            // Rotate the arrow to point towards the mouse cursor
            float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
            arrowClone.transform.rotation = Quaternion.Euler(0, 0, angle);

            // Set the arrow's velocity
            arrowClone.GetComponent<Rigidbody2D>().velocity = arrowClone.transform.right * velocity;

            // Set the arrow's lifetime
            Destroy(arrowClone, arrowLifetime);

            // Reset the arrowTimer
            arrowTimer = 0f;
        }

        // Update the arrow timer
        arrowTimer += Time.deltaTime;

        // Check if the arrow timer exceeds a certain time, then hide the arrow
        if (arrowTimer > arrowLifetime)
        {
            // Optionally, you can hide or destroy the arrow here
        }
    }
}
