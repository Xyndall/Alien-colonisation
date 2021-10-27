using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    public GameObject personObj;
    public int maxPeople = 30;
    int peopleCount;

    int[] locationSpawns = { -7, 16 };
    public List<GameObject> PersonStore = new List<GameObject>();

    float timeDelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {  
        SpawnInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        if (maxPeople < 30)
        {
            SpawnInstantiate();
        }
    }

    void SpawnInstantiate()
    {
        
        GameObject personHolder = new GameObject("Person Holder");
      

        for (int person = 0; person < maxPeople; person++)
        {
            int pick = Random.Range(0, 2);
            float offset = Random.Range(10, 50);
            Vector3 spawnPos = new Vector3(locationSpawns[pick] + offset, 0, 0);
            GameObject personcopy = Instantiate(personObj, spawnPos, transform.rotation, personHolder.transform);
            
            PersonStore.Add(personcopy);
            personcopy.name = "person" + (person+ 1);
            personcopy.tag = "NPC";
        }   
    }
    
    
}