﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyAi : MonoBehaviour
{
    public GameObject player = null;
    public GameObject Bullet = null;
    
    public float fireRate = 5;
    public float maxFireRate = 5;

    public float bulletSpeed = 5;

    
    Rigidbody2D rb = null;

    public float moveSpeed = 5;
    public float maxMoveSpeed = 5;
    public bool isShooting = false;
    Vector3 dir = Vector3.left;

    public GameObject point1 = null;
    public GameObject point2 = null;

    public GameObject tank = null;
    Vector3 ScaleChange = Vector3.zero;
    public float left = 0.5f, right = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Transform>();
        
        moveSpeed = maxMoveSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShooting)
        {
            transform.Translate(dir * moveSpeed * Time.deltaTime);
            
        }
        else
        {
            moveSpeed = 0;
        }
        

        if (transform.position.x <= point1.transform.position.x)
        {
            dir = Vector3.right;
            ScaleChange = new Vector3(0.5f, 0.5f, 0.5f);
            tank.transform.localScale = ScaleChange;
        }
        else if (transform.position.x >= point2.transform.position.x)
        {
            dir = Vector3.left;
            ScaleChange = new Vector3(-0.5f, 0.5f, 0.5f);
            tank.transform.localScale = ScaleChange;
        }


        if (fireRate <= 0)
        {
            isShooting = true;
            StartCoroutine(FireBullet());
        }
        else
        {
            isShooting = false;
            moveSpeed = maxMoveSpeed;
            fireRate -= Time.deltaTime;
        }


    }



    IEnumerator FireBullet()
    {
        fireRate = maxFireRate;
        yield return new WaitForSeconds(fireRate);

        
        GameObject instBullet = Instantiate(Bullet, transform.position, player.transform.rotation);
        rb = instBullet.GetComponent<Rigidbody2D>();
        Vector2 dir = player.transform.position - instBullet.transform.position;
        rb.AddForce(dir * bulletSpeed);

        Debug.Log("fire");

        
    }



}