﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplecursorfollow : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        mousePos .z = 0; speed = 150; 
        transform.position = Vector3.Lerp(transform.position, mousePos , speed * Time.deltaTime);
    }
}
