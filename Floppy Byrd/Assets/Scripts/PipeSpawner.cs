using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float spawnDelay = 2f;
    [SerializeField] float posRange = 1f;
    [SerializeField] GameObject pipesPrefab;
    [SerializeField] GameObject sinusoidPipesPrefab;
    [SerializeField] GameObject coinPrefab;

    float nextSpawn;
    float prevPos = 0;

    private void Start() {
        SetNextSpawnTime();
        Spawn();
    }

    void Update() {
        if (Time.time > nextSpawn) {
            SetNextSpawnTime();
            Spawn();
        }
    }

    void Spawn() {
        float newPos = prevPos + Random.Range(-posRange/2f, posRange/2f);
        newPos = Mathf.Clamp(newPos, -2f, 2f);
        prevPos = newPos;
        float spawnChoice = Random.Range(0f, 1f);
        GameObject prefab;
        if (spawnChoice <= 0.6) {
            prefab = pipesPrefab;
        }
        else if (spawnChoice <= 0.9) {
            prefab = sinusoidPipesPrefab;
        }
        else {
            prefab = coinPrefab;
        }
        Instantiate(prefab, transform.position + new Vector3(0f, newPos, 0f), Quaternion.identity);
    }

    void SetNextSpawnTime() {
        nextSpawn = Time.time + spawnDelay;
    }

}
