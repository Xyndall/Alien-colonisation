using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAi : MonoBehaviour
{
    public float walkingSpeed = 2;
    public float runningSpeed = 5;

    
    
    // Start is called before the first frame update
    void Start()
    {
      GameObject rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = new Vector2(walkingSpeed * Time.deltaTime, 0);
    }
}
