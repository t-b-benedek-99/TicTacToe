using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{

    public GameObject AboutPanel;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadAboutScreen()
    {
        AboutPanel.SetActive(true);
    }

    public void CloseAboutScreen()
    {
        AboutPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
