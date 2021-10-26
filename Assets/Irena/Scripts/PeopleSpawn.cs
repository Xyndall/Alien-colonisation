using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    public int peopleMax = 30;
    int peopleCount;
    public GameObject peopleSprite;

    public GameObject leftSpawn;
    public GameObject rightSpawn;
    
    

    // Start is called before the first frame update
    void Start()
    {
          PeopleSpawnOnScreen();

    }

    // Update is called once per frame
    void Update()
    {
        PeopleSpawnOnScreen()
    }

    void PeopleSpawnOnScreen()
    {
        GameObject peopleHolder = new GameObject("People Holder");

        for (int people = 0; people < peopleMax; people++)
        {
          GameObject peopleCopy =  Instantiate(peopleSprite, new Vector3(leftSpawn.transform.position.x, leftSpawn.transform.position.y, leftSpawn.transform.position.z), transform.rotation, peopleHolder.transform);
          peopleCopy.name = "person:" + (people + 1);
          print("Person copied");

         
        }

       
    }
}
