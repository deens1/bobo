using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float attacksPerSecond;
    
}
public class Sword : Weapon
{
    // Specific properties and methods for swords
}

public class Bow : Weapon
{
    [SerializeField] private float velocity;
    [SerializeField] public float arrowLifetime = 2f;
}