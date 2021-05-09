using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banking : MonoBehaviour
{
    public float GameScore = 0;
    public float Multiplyer = 0;
    static public float BankedScore = 0;
    public float PScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            PScore = collision.gameObject.GetComponent<Score>().sscore;
            GameScore = GameScore + PScore;
            multiplyerFunction(PScore);
            
            PScore = 0;
            
        }


    }
    public void multiplyerFunction(float Ps)
    {
        if (Ps < 3)        ///multiplyer starts kickking in when player has 3 coins minimum
        {
            Multiplyer = 1f;
        }

        if (Ps == 3 && Ps < 5)        ///multiplyer starts kickking in when player has 3 coins minimum
        {
            Multiplyer = 1.5f;
            
        }
        if (Ps >= 5)        ///multiplyer starts kickking in when player has 3 coins minimum
        {
            Multiplyer = 1.5f;
        }
        BankedScore = GameScore * Multiplyer;
        Debug.Log(BankedScore);
    }
}