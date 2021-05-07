using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public Sprite newSprite;
    private bool opened = false;
    void Start()
    {
        GameObject ScoreUp = GameObject.Find("Player");
        
        //this will immediately change your sprite to the new one
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (opened == false)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                collision.gameObject.GetComponent<Score>().sscore++;
            }
            

            opened = true;
        }
    }
}