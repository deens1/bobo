using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpStats : MonoBehaviour
{
    private float expAmount;

    public float GetExpAmount() { return  expAmount; }

    public void SetXpAmount(float xpAmount) { this.expAmount = xpAmount; }
}
