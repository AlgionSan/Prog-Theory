using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemiesPrefab;


    [SerializeField] float xSpawn=4; // for x position
    [SerializeField] float ySpawn = 1;
    [SerializeField] float zSpawn = 12;


    private float spawnRate = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnBallsRandomly());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnBallsRandomly()
    {
        //if is game active for UI main true then spawn
        while (UI_Main_Scene.instance.isGameActive)
        {
            Debug.Log("Spawn Rate: " + spawnRate);
            yield return new WaitForSeconds(spawnRate);

            //used an int randomize to get a whole number when randomizing between 3-7 seconds
            int randomSpawnRate = Random.Range(2, 6);
            spawnRate = randomSpawnRate;

            //randomize enemyPrefab index
            int index = Random.Range(0, enemiesPrefab.Count);
            Instantiate(enemiesPrefab[index], RandomSpawnPos(), enemiesPrefab[index].transform.rotation);

        }
        //extra measure(?)
        StopAllCoroutines();

    }


    Vector3 RandomSpawnPos()
    {
        //spawn randomly in the x axis but has specific y and z spawn
        return new Vector3(Random.Range(-xSpawn, xSpawn), ySpawn, zSpawn);


    }


}
