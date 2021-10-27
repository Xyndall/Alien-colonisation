using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOmovement : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Tracking the Mouse
        mousePosition = Input.mousePosition;
        //Has Camera follow the mouse
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //Moves between Points
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    //Physic based Parts for following the mouse
    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
