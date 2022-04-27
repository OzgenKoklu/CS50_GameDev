using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Input : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
