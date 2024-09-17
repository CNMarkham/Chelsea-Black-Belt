using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadCreditScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadCutscene()
    {
        SceneManager.LoadScene("Cutscene");
    }

    public void RestartGame()
    {
        GameTime.levelCounter = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
