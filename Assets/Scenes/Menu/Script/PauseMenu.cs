using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    

    public GameObject pauseMenuUI;


    private void Start()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        Debug.Log(GameIsPaused);
       
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("GameScene");
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
