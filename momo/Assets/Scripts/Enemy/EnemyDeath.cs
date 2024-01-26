using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject xpPoint;

    private void Start()
    {
        Death();
    }

    public void Death()
    {
        GameObject newXpPoint = Instantiate(xpPoint, gameObject.transform.position, Quaternion.identity);
        newXpPoint.GetComponent<ExpStats>().SetXpAmount(5);
        Destroy(gameObject);
    }
}
