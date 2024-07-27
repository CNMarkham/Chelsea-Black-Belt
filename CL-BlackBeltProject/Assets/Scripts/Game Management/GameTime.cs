using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    public static int levelCounter = 0;
    public Text gameCountdown;
    public float totalGameTime;
    public GameObject gameCursor;
    // Start is called before the first frame update
    void Start()
    {
        switch(levelCounter)
        {
            case 1:
                totalGameTime = 60;
                break;
            case 2:
                totalGameTime = 50;
                break;
            case 3:
                totalGameTime = 45;
                break;
            case 4:
                totalGameTime = 35;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if (levelCounter == 0)
        {
            gameCountdown.text = "";
            return;
        } 

        totalGameTime -= Time.deltaTime;        
        //sets GameCountdown's text to rounded number of totalGameTime
        gameCountdown.text = Mathf.Round(totalGameTime).ToString();      

        if (totalGameTime <= 0)
        {   //loads lose scene
            SceneManager.LoadScene(4);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gameCursor.SetActive(false);
        }
    }
}
