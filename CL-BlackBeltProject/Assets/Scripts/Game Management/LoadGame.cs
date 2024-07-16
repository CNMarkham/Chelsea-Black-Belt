using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadCreditScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCutscene()
    {
        SceneManager.LoadScene(5);
    }
}
