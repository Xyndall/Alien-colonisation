using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    public GameObject person;
    public int maxPeople = 30;
    int peopleCount;

    int[] locationSpawns = { -7, 16 };

    public GameObject leftSpawn, rightSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SpawnInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnInstantiate()
    {
        int pick = Random.Range(0, 2);
        /*for (person < maxPeople, peopleCount++)*/
        {

        }
        Vector3 spawnPos = new Vector3(locationSpawns[pick], 0, 0);

        GameObject personcopy = Instantiate(person, spawnPos, transform.rotation);
    }
}