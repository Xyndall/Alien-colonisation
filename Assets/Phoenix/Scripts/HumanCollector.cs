using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanCollector : MonoBehaviour
{
    public float Humans = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "NPC")
        {
            Destroy(other.gameObject);
            Debug.Log("Collected");
        }
    }

}
