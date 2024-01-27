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
    [SerializeField] public static float currXp;
    [SerializeField] public static float xpToLevelUp;
    [Header("Model")]
    [SerializeField] public static float size = 1;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public float GetCurrHealth() { return currHealth; }

    public float GetMaxHealth() { return maxHealth; }

    public float GetSpeed() { return speed; }

    public float GetCurrXp() {  return currXp; }

    public float GetXPToLevelUp() {  return xpToLevelUp; }

    public void SetCurrHealth(float currHealth) { this.currHealth = currHealth; }

    //public void SetMaxHealth(float maxHealth) { this.maxHealth = maxHealth; }

    //public void SetSpeed(float speed) { this.speed = speed; }

    public void AddXp(float xp)
    {
        currXp += xp;
        if (xpToLevelUp <= currXp)
        {
            LevelUp();

        }
    }

    void LevelUp()
    {

    }
}
