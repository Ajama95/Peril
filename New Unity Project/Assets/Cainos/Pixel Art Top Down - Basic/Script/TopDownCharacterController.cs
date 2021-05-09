using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed = 5;
        public Transform teleport;
        public Transform teleport2;
        private Animator animator;
        bool canDash = true;
        bool dashed;
        public float dashtimer = 10f;
        private float dash = 5000f;
        Rigidbody2D rb;
        public GameObject GameOver;
        public static bool GOBool = false;
        private void Start()
        {
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
            
                Move();
            if (GOBool == true)
            {

                GameOver.SetActive(true);
                Time.timeScale = 0f;
            }
           
        }

        void FixedUpdate()
        {
            
        }

            private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Teleport")
            {
                this.transform.position = teleport.position;

            }
            if (collision.gameObject.tag == "Teleport2")
            {
                this.transform.position = teleport.position;

            }
            if (collision.gameObject.tag == "Ghost")
            {
                GOBool = true;

       
    }
        }

        private void Debuff(float playerscore)
        {
           if(playerscore < 0)
            {
                speed = 5;
            }
            if (playerscore > 0 || playerscore < 2 )
            {
                speed = 3;
                canDash = false;
            }


        }

      


        public void Move()
        {
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 3);


                if (Input.GetKey(KeyCode.Space))
                {
                    if (canDash == true)
                    {
                        rb.AddForce(Vector2.right * dash, ForceMode2D.Force);
                        Debug.LogError("hello");
                        canDash = false;
                    }
                }

            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 2);

                if (Input.GetKey(KeyCode.Space))
                {
                    if (canDash == true)
                    {
                        rb.AddForce(Vector2.left * dash, ForceMode2D.Force);
                        Debug.LogError("hello");
                        canDash = false;
                    }
                }
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
                if (Input.GetKey(KeyCode.Space))
                {
                    if (canDash == true)
                    {
                        rb.AddForce(Vector2.up * dash, ForceMode2D.Force);
                        Debug.LogError("hello");
                        canDash = false;
                    }
                }
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
                if (Input.GetKey(KeyCode.Space))
                {
                    if (canDash == true)
                    {
                        rb.AddForce(Vector2.down * dash, ForceMode2D.Force);
                        Debug.LogError("hello");
                        canDash = false;
                    }
                }
            }

            if(canDash == false)
            {
                dashtimer -= Time.deltaTime;
            }

            if(dashtimer <= 0)
            {
                dashtimer = 10f;
                canDash = true;
            }


            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
       
    }

   
}
