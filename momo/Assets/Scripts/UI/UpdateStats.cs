using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateStats : MonoBehaviour
{
    TextMeshProUGUI statValueTMP;
    GameObject statValue;
    // Start is called before the first frame update
    void Start()
    {
        
        //statValue.text = PlayerStats.maxHealth.ToString();
        foreach (var stat in gameObject.GetAllChilds())
        {
            Debug.Log(stat);
            statValue = stat.transform.Find("StatValue").gameObject;
            statValueTMP = statValue.GetComponent<TextMeshProUGUI>();
            if (statValue.CompareTag("speedStat"))
            {
                //statValueTMP.text = "53";
                statValueTMP.text = PlayerStats.speed.ToString();
            }
            else if (statValue.CompareTag("healthStat"))
            {
                statValueTMP.text = PlayerStats.maxHealth.ToString();
            }
            else if (statValue.CompareTag("sizeStat"))
            {
                statValueTMP.text = PlayerStats.size.ToString();
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}

public static class ClassExtension
{
    public static List<GameObject> GetAllChilds(this GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
