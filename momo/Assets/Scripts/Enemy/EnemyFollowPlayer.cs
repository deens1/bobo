using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed of the enemy

    private Transform player; // Reference to the player's Transform

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Assuming the player has the tag "Player"
    }

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction from the enemy to the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize(); // Normalize to get a unit vector

            // Move the enemy towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
