using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float damage;
    [SerializeField] GameObject explotion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit!");
            collision.gameObject.GetComponent<EnemyStats>().Damage(damage);
            transform.Find("Particles").GetComponent<DeleteAfter>().AboutToDie();           
            GameObject explotionClone = Instantiate(explotion, transform.position, Quaternion.identity);
            explotionClone.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
        }
    }
}
