using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ChestOpen : MonoBehaviour
{
    public Sprite newSprite;
    private bool opened = false;
    AudioSource Coins;
    public AudioClip coinNoise;
    void Start()
    {
       
        
        //this will immediately change your sprite to the new one
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")   //check if player collided 
        {
            
            if (opened == false)  //bool to ensure player cant keep increasing score
            {
                AudioSource.PlayClipAtPoint(coinNoise, this.transform.position, 1f);
                gameObject.GetComponent<SpriteRenderer>().sprite = newSprite; //load new sprite to chest opening 
                collision.gameObject.GetComponent<Score>().sscore++;   //increment the score script on the player
                
            }
            

            opened = true;
        }
    }
}