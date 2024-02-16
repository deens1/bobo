using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] public float currHealth;
    [SerializeField] public static float maxHealth = 100f;
    [Header("Speed")]
    [SerializeField] public static float speed = 4;
    [Header("Xp")]
    [SerializeField] public static float currExp = 0;
    [SerializeField] public static float expToLevelUp = 100;
    [Header("Model")]
    [SerializeField] public static float size = 1;

    private GameObject expBar;

    private void Start()
    {
        expBar = GameObject.FindWithTag("ExpBar");
        expBar.GetComponent<ExpBar>().UpdateExpBar();
        currHealth = maxHealth;
    }

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }

    public float GetCurrExp() {  return currExp; }

    public float GetExpToLevelUp() {  return expToLevelUp; }

    public void SetCurrHealth(float currHealth) { this.currHealth = currHealth; }

    public void AddExp(float exp) {
        currExp += exp;
        if (expToLevelUp <= currExp)
        {
            LevelUp();
            currExp = 0;
        }
        expBar.GetComponent<ExpBar>().UpdateExpBar();
    }

    void LevelUp()
    {

    }

    //public void SetMaxHealth(float maxHealth) { this.maxHealth = maxHealth; }

    //public void SetSpeed(float speed) { this.speed = speed; }


}
