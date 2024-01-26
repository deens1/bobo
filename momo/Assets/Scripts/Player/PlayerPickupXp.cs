using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupXp : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("xp"))
        {
            Destroy(collision.gameObject);
        }
    }
}
