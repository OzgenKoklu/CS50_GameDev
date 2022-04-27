using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAi : MonoBehaviour
{
    private float speed;
    public Rigidbody2D rb2d;
    public Vector3 startPosition;
    GameObject theBall;
    private Rigidbody2D computer2d;
    void Start()
    {
        startPosition = new Vector3(8.41f, 0, 0);
        computer2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        speed = 6.12f;

        if (theBall == null)
        {
            theBall = GameObject.FindGameObjectWithTag("Ball");
        }

        rb2d = theBall.GetComponent<Rigidbody2D>();

        if (rb2d.velocity.x > 0)
        {

            if (rb2d.velocity.y > 0)
            {
                if (rb2d.position.y > computer2d.position.y)
                {
                    MoveUp();
                }

                if (rb2d.position.y < computer2d.position.y)
                {
                    MoveDown();
                }
            }

            if (rb2d.velocity.y < 0)
            {
                if (rb2d.position.y > computer2d.position.y)
                {
                    MoveUp();
                }
                if (rb2d.position.y < computer2d.position.y)
                {
                    MoveDown();
                }
            }
        }

       
    }
    void MoveDown()
    {
        if (Mathf.Abs(rb2d.velocity.y) > speed)
        {
            computer2d.position += Vector2.down * speed * Time.deltaTime;
        }
        else
        {
            computer2d.position += Vector2.down * speed * Time.deltaTime;
        }
    }

    void MoveUp()
    {
        if (Mathf.Abs(rb2d.velocity.y) > speed)
        {
            computer2d.position += Vector2.up * speed * Time.deltaTime;
        }
        else
        {
            computer2d.position += Vector2.up * speed * Time.deltaTime;
        }
    }

    public void Reset()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
