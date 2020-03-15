using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject carPrefab;
    private bool isSpawned = false;

    void Update()
    {
        if(!isSpawned)
        {
            StartCoroutine(DelaySpawn());
        }
    }

    IEnumerator DelaySpawn()
    {
        isSpawned = true;
        yield return new WaitForSeconds(1);
        Spawn();
    }

    void Spawn()
    {
        int index = (int)Mathf.Floor(Random.Range(0.0f, 4.0f));
        if (spawnPoints != null)
        {
            Vector2 spawnPos = spawnPoints[index].transform.position;
            Instantiate(carPrefab, spawnPos, Quaternion.identity);
        }
        isSpawned = false;
    }
}
