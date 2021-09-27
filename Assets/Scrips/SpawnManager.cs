using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        InvokeRepeating("SpawnEvilAimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnEvilAimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 evilPosLR = new Vector3(-18, 0, Random.Range(5, 10));
        Vector3 evilPosRL = new Vector3(15, 0, Random.Range(5, 10));
        Vector3 animalRotationLR = new Vector3(0, 90, 0);
        Vector3 animalRotationRL = new Vector3(0, 270, 0);

        Instantiate(animalPrefabs[animalIndex], evilPosLR,Quaternion.Euler(animalRotationLR));
        Instantiate(animalPrefabs[animalIndex], evilPosRL, Quaternion.Euler(animalRotationRL));
    }
}
