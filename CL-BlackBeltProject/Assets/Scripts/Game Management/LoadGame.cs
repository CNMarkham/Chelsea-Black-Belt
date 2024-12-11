using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public GameTime gameTime;
    public void SceneChanger()
    {
        SceneManager.LoadScene("MainGame");
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
        gameTime.tunaPlate.SetActive(false);
        gameTime.sushiPlate.SetActive(true);
        SceneManager.LoadScene("MainGame");
    }
}
