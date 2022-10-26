using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cou : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject spawnObject;

    void Start()
    {
        StartCoroutine("Spawner");
    }

    IEnumerator Spawner()
    {
        while(True)
        {
            yield return new WaitForSeconds(1f);
            spawnPoint = new Vector3(Random.Range(-5, 6), 5, Random.Range(-5, 6));
            Instantiate(spawnObject, spawnPoint, transform.rotation);
        }
    }
}
