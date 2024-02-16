using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public float damage;
    [SerializeField] public float attacksPerSecond;
    
}

public class Bow : Weapon
{
    [SerializeField] private float velocity;
    [SerializeField] public float arrowLifetime = 2f;
}