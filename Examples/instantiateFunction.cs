using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateFunction : MonoBehaviour
{

    public Vector3 spawnPoint;
    public GameObject SpawnObject;

    void Start()
    {
    }

    private void FixedUpdate()
    {
        spawnPoint = new Vector3(Random.Range(-5, 6), 5, Random.Range(-5,6));
        Instantiate(SpawnObject, spawnPoint, transform.rotation);
    }
}
