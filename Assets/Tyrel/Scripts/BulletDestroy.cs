using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public GameObject explosion = null;
    
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject explode = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(explode, 0.5f);
            Destroy(gameObject);
        }
        
        if (collision.gameObject.CompareTag("Death"))
        {
            GameObject explode = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(explode, 0.5f);
            Destroy(gameObject);
        }



    }

}
