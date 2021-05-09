using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public void MainMenu()
    {
        GameOverCanvas.SetActive(false);
        Time.timeScale = 0f;
        SceneManager.LoadScene("MainMenu");
       

    }





}
