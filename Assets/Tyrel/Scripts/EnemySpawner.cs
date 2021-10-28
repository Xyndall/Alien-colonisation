using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    
    float randx;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;

    public List<GameObject> Tanks = new List<GameObject>();

    public GameObject Player = null;
    public GameObject Bullet = null;
    public GameObject point1 = null;
    public GameObject point2 = null;
    public GameObject enemy = null;
    public GameObject enemy2 = null;

    public SpriteRenderer sprites = null;

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
        else
        {
            spawnRate = 4.6f;
        }

    }

    void SpawnTanks()
    {
        nextSpawn = Time.time + spawnRate;
        randx = Random.Range(-10, 10);
        whereToSpawn = new Vector2(randx, transform.position.y);
        GameObject tanks = Instantiate(enemy, whereToSpawn, Quaternion.identity);
        BaseEnemyAi baseAiScript = tanks.AddComponent<BaseEnemyAi>();
        //SpriteRenderer tankSprite =  tanks.GetComponent<SpriteRenderer>();
        //tankSprite.sprite = 
        baseAiScript.tank = tanks;
        baseAiScript.player = Player;
        baseAiScript.Bullet = Bullet;
        baseAiScript.point1 = point1;
        baseAiScript.point2 = point2;
        
        
        Tanks.Add(tanks);

    }

}
