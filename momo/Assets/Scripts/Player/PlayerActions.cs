using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerStats stats;
    HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<PlayerStats>();
        healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
    }

    public void AttackPlayer(float damage)
    {
        stats.SetCurrHealth(stats.GetCurrHealth() - damage);
        healthBar.UpdateHealthBar();
    }
}
