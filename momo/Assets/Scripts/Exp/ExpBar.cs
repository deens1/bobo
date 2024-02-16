using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    Slider expBar;
    PlayerStats stats;

    private void Start()
    {
        expBar = GetComponent<Slider>();
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    public void UpdateExpBar()
    {
        expBar.value = stats.GetCurrExp() / stats.GetExpToLevelUp();
    }
}
