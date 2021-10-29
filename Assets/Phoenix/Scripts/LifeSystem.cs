using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{
    public GameObject[] ships;
    public int life;
    private bool dead;

    private void Start()
    {
        life = ships.Length;
    }

    public void Update()
    {
        if (dead == true)
        {
            Debug.Log("Out of Lives");
            SceneManager.LoadScene(1);
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(ships[life].gameObject);
            if (life <= 0)
            {
                dead = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
        }
    }
}
