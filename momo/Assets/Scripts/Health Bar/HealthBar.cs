using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider healthBar;
    PlayerStats stats;

    private void Start()
    {
        healthBar = GetComponent<Slider>();
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    public void UpdateHealthBar()
    {
        healthBar.value = stats.GetCurrHealth() / stats.GetMaxHealth();
    }
}
