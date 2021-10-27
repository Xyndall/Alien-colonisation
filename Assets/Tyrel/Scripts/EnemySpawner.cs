using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy = null;
    float randx;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;

    public List<GameObject> Tanks = new List<GameObject>();
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > nextSpawn)
        {
            SpawnTanks();

        }

        if(Tanks.Count >= 10)
        {
            spawnRate = 100;
        }

    }

    void SpawnTanks()
    {
        nextSpawn = Time.time + spawnRate;
        randx = Random.Range(-10, 10);
        whereToSpawn = new Vector2(randx, transform.position.y);
        GameObject tanks = Instantiate(enemy, whereToSpawn, Quaternion.identity);
        Tanks.Add(tanks);
    }

}
