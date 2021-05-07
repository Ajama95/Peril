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
        Patroling = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Patroling)
        {
            Patrol();
        }
    }

    private void FixedUpdate()
    {
        if(Patroling == true)
        {
            turn = !Physics2D.OverlapCircle(p1.position, 0.1f, groundlayer);
        }
    }

    void Patrol()
    {
        if(turn)
        {
            flip();
        }
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);

    }
    void flip()
    {   Patroling = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        Patroling = true;
    }




}
