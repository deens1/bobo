using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float maxHealth;
    [SerializeField] private float currHealth;
    [Header("Speed")]
    [SerializeField] private float speed;
    [Header("Attack")]
    [SerializeField] private float attackCooldown = 0.3f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private int attackDamage = 10;
    [Header("Exp")]
    [SerializeField] private float expAmount = 10;
    [SerializeField] private GameObject expPoint;

    Animator animator;

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }

    public float GetAttackCooldown() {  return attackCooldown; }

    public float GetAttackRange() {  return attackRange; }

    public int GetAttackDamage() {  return attackDamage; }

    private void Start()
    {
        currHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void Damage(float damage)
    {
        currHealth -= damage;
        animator.SetTrigger("Hit");
        if (currHealth <= 0) Die();
    }

    void Die()
    {
        GameObject newExpPoint = Instantiate(expPoint, gameObject.transform.position, Quaternion.identity);
        newExpPoint.GetComponent<ExpStats>().SetXpAmount(expAmount);
        Destroy(gameObject);
    }
}
