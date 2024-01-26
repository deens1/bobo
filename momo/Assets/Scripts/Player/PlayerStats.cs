using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float currHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float speed;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }

    public void SetCurrHealth(float currHealth) { this.currHealth = currHealth; }

    public void SetMaxHealth(float maxHealth) { this.maxHealth = maxHealth; }

    public void SetSpeed(float speed) { this.speed = speed; }
}
