using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] AnimalPrefabsHorizantal;
    [SerializeField] private GameObject[] AnimalPrefabsVerticalLeft;
    [SerializeField] private GameObject[] AnimalPrefabsVerticalRight;

    [SerializeField] private int RandomPosX = 20;
    [SerializeField] private int RandomPosZ = 12;

    [SerializeField] private float StartDelay = 2;
    [SerializeField] private float SpawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("RandomSpawnAnimalHorizontal", StartDelay, SpawnInterval);
        InvokeRepeating("RandomSpawnAnimalVertical", StartDelay, SpawnInterval);
    }

    void RandomSpawnAnimalHorizontal()
    {
        int AnimalIndex = Random.Range(0, AnimalPrefabsHorizantal.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-RandomPosX, RandomPosX + 1), 0, RandomPosZ);
        Instantiate(AnimalPrefabsHorizantal[AnimalIndex], spawnPos, AnimalPrefabsHorizantal[AnimalIndex].transform.rotation);
    }

    void RandomSpawnAnimalVertical()
    {
        int AnimalIndex = Random.Range(0, AnimalPrefabsVerticalLeft.Length);

        Vector3 spawnPosLeft = new Vector3( -22f , 0, Random.Range(-1, 15));
        Instantiate(AnimalPrefabsVerticalLeft[AnimalIndex], spawnPosLeft, AnimalPrefabsVerticalLeft[AnimalIndex].transform.rotation);


        AnimalIndex = Random.Range(0, AnimalPrefabsVerticalRight.Length);

        Vector3 spawnPosRight = new Vector3(22f, 0, Random.Range(-1, 15));
        Instantiate(AnimalPrefabsVerticalRight[AnimalIndex], spawnPosRight, AnimalPrefabsVerticalRight[AnimalIndex].transform.rotation);

    }
}
