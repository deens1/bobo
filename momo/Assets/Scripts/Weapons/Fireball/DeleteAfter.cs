using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfter : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Something());
    }

    public void AboutToDie()
    {
        transform.parent = null;
        GetComponent<ParticleSystem>().emissionRate = 0;
        transform.localScale = new Vector3(1, 1, 1);
    }

    IEnumerator Something()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }
}
