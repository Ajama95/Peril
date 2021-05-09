using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public bool Patroling;
    private bool turn;

    public float speed;

    Rigidbody2D rb;

    public Transform p1;
    public Transform p2;
    public LayerMask groundlayer;

    // Start is called before the first frame update
    void Start()
    {
         speed = 100f;
    Patroling = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "P1")
        {
            speed *= -1;
        }
        if (collision.tag == "P2")
        {
            speed *= -1;
        }
    }
    
        

    }
    




