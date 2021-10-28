using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float attractionForce = 0.1f;
    public GameObject Ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //Destroy GameObject when clicked
        Destroy(gameObject, 1);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        Vector3 vect = Ship.transform.position - transform.position;
        vect = vect.normalized;
        rb.AddForce(vect * attractionForce);
    }

}
