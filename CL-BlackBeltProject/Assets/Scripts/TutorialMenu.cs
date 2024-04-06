using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartTutorial()
    {
        GameTime.levelCounter = 0;       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
    //make level counter to 0 and the no timer game will restart
    }

    public void ChangeLevel()
    {
        GameTime.levelCounter = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //the restart pop up will disappear
    //make level counter 1 and next level will be played 
    }

}
