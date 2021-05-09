using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   public float sscore;
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("Score", sscore);

        }


    public void LoadData()
    {
        sscore = PlayerPrefs.GetFloat("Score");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Teleoprt")
        {

            SaveData();
        }
    }

}