using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
        public float DashTime;
        public float Dashforce;
        private bool isDashing;
        public float DashStartTime;
        private Animator animator;
        private float ScoreDebuff;
        Rigidbody2D rb;
        private int Direction;
        private float moveX;
        private void Start()
        {
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();

        }


        private void Update()
        {
            Dashmanager();
            ScoreDebuff = GetComponent<Score>().sscore;

            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
            Debuff();
        }
        private void Debuff()
        {
            switch(ScoreDebuff)
            {
                case 0:
                    speed = 5f;
                    break;

                case 1:
                    speed = 4f;
                    break;

                case 2:
                    speed = 1f;
                    break;

                case 3:
                    //dashing disabled here
                    break;

            }



        }

        private void Dashmanager()
        {

        }

    }


    




}
