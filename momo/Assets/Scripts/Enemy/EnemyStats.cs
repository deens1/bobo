using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float currHealth;
    [SerializeField] private float maxHealth;
    [Header("Speed")]
    [SerializeField] private float speed;
    [Header("Attack")]
    [SerializeField] private float attackCooldown = 0.3f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private int attackDamage = 10;

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }

    public float GetAttackCooldown() {  return attackCooldown; }

    public float GetAttackRange() {  return attackRange; }

    public int GetAttackDamage() {  return attackDamage; }

}
