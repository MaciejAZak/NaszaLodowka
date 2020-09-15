using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OptionsScene()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
