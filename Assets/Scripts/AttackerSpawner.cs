using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    bool spawn = true;

    [SerializeField] private Attacker attackerPrefab = default;
    [SerializeField] private bool isRandom = false;
    [SerializeField] private float minSpawnDelay = 1f;
    [SerializeField] private float maxSpawnDelay = 2f;
    [Header("If not random, flat seconds")]
    [SerializeField] private float flatSpawnDelay = 2f;


    IEnumerator Start()
    {
        while (spawn)
        {
            if (isRandom == true)
            {
                yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            }
            else
            {
                yield return new WaitForSeconds(flatSpawnDelay);
            }
            spawnNewEnemy();
        }

    }

    private void spawnNewEnemy()
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

}
