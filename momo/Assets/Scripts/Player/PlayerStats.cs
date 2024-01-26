using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float currHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float speed;

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }
}
