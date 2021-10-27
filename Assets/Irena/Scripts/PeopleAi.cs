﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAi : MonoBehaviour
{
    // People Speed 
    public float walkingSpeed = 2;
    public float runningSpeed = 5;
    public float defaultSpeed = 0;

    // People default position 
    float onGround = -0.86f;
  
    //Panicked state 
    public bool isPanicked = false;

    Rigidbody2D rb;

    public Animator animator;

    public GameObject ufo;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PersonState();

        if(this.gameObject.transform.position.y > onGround)
        {
            this.gameObject.transform.Translate(defaultSpeed * Time.deltaTime, 0, 0);
            
        }

       /* OnDestroy();*/
    }

    void PersonState()
    {
        switch (isPanicked)
        {
            case false:
                this.gameObject.transform.Translate(walkingSpeed * Time.deltaTime, 0, 0);
                animator.SetFloat("Walkspeed",Mathf.Abs(walkingSpeed));

                break;

            case true:
                this.gameObject.transform.Translate(runningSpeed * Time.deltaTime, 0, 0);
                break;
        }
    }


    private void OnTriggerEnter2D(Collider2D panickedState)
    {
        print("collided");
        isPanicked = true;
    }

   
    //not working
    private void OnDestroy()
    {
        if(this.gameObject.transform.position == ufo.transform.position)
        {
            Destroy(this.gameObject);
            print("destroyed");
        }
    }
}

