using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D charbody;
    private Vector2 velocity;
    private Vector2 inputMove;

    // Start is called before the first frame update
    void Start()
    {
        //speed for x and y directions. That is why we use Vector2
        velocity = new Vector2(speed, speed);

        //take the object from the gameObject
        charbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMove = new Vector2
        (
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")

        );
    }

    private void FixedUpdate()
    {
        //change in the 2D space
        Vector2 delta = inputMove * velocity * Time.deltaTime;
        Vector2 newPosition = charbody.position + delta;
        charbody.MovePosition(newPosition);
    }
}
