using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   public static bool Gameispaused = false;

   public GameObject pausemenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gameispaused)
            {
                Resume();
            } else
            {
                Pause();
            }

        }
    }
    public void Resume ()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gameispaused = false;

    }

    void Pause ()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused = true;
    }
    
    public void quitgame()
    {
        Application.Quit();
    }


} 

