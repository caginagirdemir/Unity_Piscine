using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cou : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject spawnObject;
    public float respawnDelay = 1f;
    Coroutine spawnRoutine;

    public void Start()
    {
        spawnRoutine = StartCoroutine(Spawner());
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopCoroutine(spawnRoutine);
        }
    }

    IEnumerator Spawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            spawnPoint = new Vector3(Random.Range(-5, 6), 5, Random.Range(-5, 6));
            Instantiate(spawnObject, spawnPoint, transform.rotation);
        }
    }
}
