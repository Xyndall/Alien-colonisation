using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
{

    
    float randx;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;

    public List<GameObject> PeopleList = new List<GameObject>();

    
    public GameObject point1 = null;
    public GameObject point2 = null;
    public GameObject People = null;
    

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

        if(PeopleList.Count >= 10)
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
        GameObject people = Instantiate(People, whereToSpawn, Quaternion.identity);
        BaseEnemyAi baseAiScript = people.AddComponent<BaseEnemyAi>();
        //SpriteRenderer tankSprite =  tanks.GetComponent<SpriteRenderer>();
        //tankSprite.sprite = 
        //baseAiScript.People = People;
        
        baseAiScript.point1 = point1;
        baseAiScript.point2 = point2;
        
        
        PeopleList.Add(people);

    }

}
