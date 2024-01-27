using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddPointToStat : MonoBehaviour
{
    UpdateStats updateStats;

    private void Start()
    {
        updateStats = GameObject.Find("Stats").GetComponent<UpdateStats>();
    }

    public void AddPoint()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(buttonName);

        if(buttonName == "AddSpeed")
        {
            PlayerStats.speed += 1;
            updateStats.UpdateAllStats();
            Debug.Log("Point added to " + buttonName);
        }

        if (buttonName == "AddHealth")
        {
            PlayerStats.maxHealth += 1;
            updateStats.UpdateAllStats();
            Debug.Log("Point added to " + buttonName);
        }

        if (buttonName == "AddSize")
        {
            PlayerStats.size += 1;
            updateStats.UpdateAllStats();
            Debug.Log("Point added to " + buttonName);
        }
    }
}
