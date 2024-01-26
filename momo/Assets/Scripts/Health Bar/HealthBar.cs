using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBar : MonoBehaviour
{
    Slider healthBar;

    private void Start()
    {
        healthBar = GetComponent<Slider>();
    }

    public void SetHealth(float health)
    {
        healthBar.value = health;
    }
}
