using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadScene(int scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
