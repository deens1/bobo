using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    GameObject player;
    public float damage;
    LineRenderer lineRenderer;
    public int numSegments = 10;
    public float maxSegmentLength = 0.5f;
    public float maxDeviation = 0.1f;

    public Vector3 shootDirection;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        lineRenderer = GetComponent<LineRenderer>();
        Debug.Log("Lightning!");

        GenerateLightning();
    }

    void GenerateLightning()
    {
        Vector3[] positions = new Vector3[numSegments];
        positions[0] = transform.position;

        for (int i = 1; i < numSegments; i++)
        {
            float t = (float)i / (float)numSegments;
            float deviation = Random.Range(-maxDeviation, maxDeviation);
            float segmentLength = Random.Range(0, maxSegmentLength);

            Vector3 direction = Quaternion.Euler(0, 0, deviation * 360f) * shootDirection;
            Vector3 newPosition = positions[i - 1] + direction * segmentLength;
            positions[i] = newPosition;
        }

        lineRenderer.positionCount = numSegments;
        lineRenderer.SetPositions(positions);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit!");
            collision.gameObject.GetComponent<EnemyStats>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
