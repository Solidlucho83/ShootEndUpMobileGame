using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class Spawn : MonoBehaviour
{
    public List<GameObject>EnemyPrebafbs;
   // public List<Transform> spawPoints;
    public Vector3 spawnReferencePosition;
    public Quaternion spawnRotation;
    public int amountToSpawn;
    public float spawnCadence;
    public float initialWaitTime;

    private void Start()
    {
        StartCoroutine(EnemySpawnCoroutine());
    }

    private IEnumerator EnemySpawnCoroutine()
    {

        yield return new WaitForSeconds(initialWaitTime);
        for (int i = 0; i < amountToSpawn; i++)
        {
            Vector3 randonPosition = new Vector3(/*Random.Range(-*/spawnReferencePosition.x, spawnReferencePosition.y, spawnReferencePosition.z);
            SpawnEnemy(randonPosition, spawnRotation);
            yield return new WaitForSeconds(spawnCadence);
        }
    }

    public void SpawnEnemy(Vector3 enemyPosition, Quaternion rotation)
    {
        int randonIndex = Random.Range(0, EnemyPrebafbs.Count);
        Instantiate(EnemyPrebafbs[randonIndex], enemyPosition, rotation);
    }
}
