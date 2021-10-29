using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAi : MonoBehaviour
{
    SpriteRenderer sr;

    // People Speed 
    public float walkingSpeed = 2;
    public float runningSpeed = 8;
    float defaultSpeed = 0;
   

    // People default position 
    float onGround = -4.6f;
  
    //Panicked state 
    public bool isPanicked = false;

    float startingPos = 16;

    Rigidbody2D rb;

    public Animator animator;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        
        PersonState();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (this.gameObject.transform.position.y == onGround)
        {
             PersonState();
        }
        else
        {
            this.gameObject.transform.Translate(defaultSpeed, 0, 0);
            animator.SetFloat("Static", 0);
            animator.SetBool("IsPanicking", true);
        }
        
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
                animator.SetBool("IsRunning", true);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D panickedState)
    {
        print("collided");
        isPanicked = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        walkingSpeed = walkingSpeed * -1;
        runningSpeed = runningSpeed * -1;
       
    }


}

