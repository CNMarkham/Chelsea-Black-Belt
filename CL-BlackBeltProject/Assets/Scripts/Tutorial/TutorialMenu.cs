using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    public GameObject popUpMenu;
    public GameObject gameCursor;
    public GameObject gameTimer;
    public GameObject fadeIn;
    public Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        if (GameTime.levelCounter >= 1)
        {
            //See the cursor
            gameCursor.SetActive(true);
            //make the timer appear
            gameTimer.SetActive(true);
            fadeIn.SetActive(false);
        }
    }
    public void RestartTutorial()
    {   
        //make level counter to 0 and the no timer game will restart
        GameTime.levelCounter = 0;       
        SceneManager.LoadScene("SampleScene");        
    }

    public void ChangeLevel()
    {
        //make level counter 1 and next level will be played 
        GameTime.levelCounter = 1;
        //the restart pop up will disappear
        popUpMenu.SetActive(false);
        //Unlock Cursor
        Cursor.lockState = CursorLockMode.None;
        //turn off movement
        movement.enabled = true;
        SceneManager.LoadScene("SampleScene");       
    }
}
