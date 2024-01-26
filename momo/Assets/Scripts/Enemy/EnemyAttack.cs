using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private EnemyStats enemyStats;
    private Transform playerTransform;
    private float attackCooldown;
    private GameObject player;
    private PlayerActions actions;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        actions = player.GetComponent<PlayerActions>();
        playerTransform = player.transform;
        enemyStats = GetComponent<EnemyStats>();
        attackCooldown = enemyStats.GetAttackCooldown();
    }

    // Update is called once per frame
    void Update()
    {
        /*        if (playerTransform != null)
                {
                    Vector3 direction = playerTransform.position - transform.position;
                    float distanceToPlayer = direction.magnitude;

                    if (distanceToPlayer <= enemyStats.GetAttackRange())
                    {
                        // Check if enough time has passed to attack again
                        if (attackCooldown <= 0f)
                        {
                            // Attack the player
                            AttackPlayer();
                            attackCooldown = enemyStats.GetAttackCooldown();  // Reset the attack timer
                        }
                        else
                        {
                            // Decrease the attack timer
                            attackCooldown -= Time.deltaTime;
                        }
                    }
                }*/

        if (attackCooldown > 0f)
        {
            attackCooldown -= Time.deltaTime;  // Decrease the attack timer
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && attackCooldown <= 0f)
        {
            AttackPlayer();
            attackCooldown = enemyStats.GetAttackCooldown();  // Reset the attack timer
        }
    }

    void AttackPlayer()
    {
        Debug.Log("Enemy attacks the player for " + enemyStats.GetAttackDamage() + " damage.");
        actions.AttackPlayer(enemyStats.GetAttackDamage());
    }
}
