using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    public GameObject popUpMenu;
    public GameObject gameCursor;
    public GameObject gameTimer;

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
        SceneManager.LoadScene(0);        
    //make level counter to 0 and the no timer game will restart
    }

    public void ChangeLevel()
    {
        GameTime.levelCounter = 1;
        //Turn Off Pop up
        popUpMenu.SetActive(false);
        //Unlock Cursors
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //See the cursor
        gameCursor.SetActive(true);
        //Make timer appear
        gameTimer.SetActive(true);
        //  SceneManager.LoadScene(0);
        //the restart pop up will disappear
        //make level counter 1 and next level will be played 
    }

}
