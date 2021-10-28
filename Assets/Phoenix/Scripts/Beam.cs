using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //Destroy GameObject when clicked
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //If it collides with something with NPC Tag is is destroyed
        if (other.gameObject.tag == "NPC")
        Destroy(other.gameObject, 1);
        Destroy(gameObject, 1);
    }
}
