using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    [Header("Total Time")]
 

    [SerializeField] private List<WavesConfig> wavesConfigs;



    [SerializeField] private Quaternion spawnRotation;


    [SerializeField] public float initialWaitTime;

    [SerializeField] public float CadenceBetweenWaves;

    


    private void Start()
    {
        StartCoroutine(EnemySpawnCoroutine());
    }



    private IEnumerator EnemySpawnCoroutine(){
        yield return new WaitForSeconds(initialWaitTime);
        foreach (var wave in wavesConfigs)
        {
            foreach (var enemy in wave.enemies)
            {
                Vector3 enemyPosition = Vector3.zero;
                if (enemy.useSpecificXPosition)
                {
                    enemyPosition = enemy.spawnRefencePosition;
                }
                else
                {
                    enemyPosition = new Vector3(Random.Range(-enemy.spawnRefencePosition.x, enemy.spawnRefencePosition.x), enemy.spawnRefencePosition.y, enemy.spawnRefencePosition.z);
                }
                Spawnenemy(enemy.EnemyPrebafbs.gameObject, enemyPosition, spawnRotation);
                yield return new WaitForSeconds(wave.cadence);
            }

            yield return new WaitForSeconds(CadenceBetweenWaves);
        }
    }  

    public void Spawnenemy(GameObject EnemyPrebafbs, Vector3 enemyPosition, Quaternion rotation)
    {
      Instantiate(EnemyPrebafbs, enemyPosition, rotation); 
    }
}
