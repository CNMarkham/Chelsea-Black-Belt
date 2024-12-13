using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class GameTime : MonoBehaviour
{
    public static int levelCounter = 0;
    public Text gameCountdown;
    public float totalGameTime;
    public GameObject gameCursor;
    public PlayableDirector tunaCutscene;
    public GameObject seaweed;
    public GameObject salmon;
    public GameObject tunaNigiriSigns;
    public GameObject SushiRollSigns;
    public GameObject tunaPlate;
    public GameObject sushiPlate;
    public GameObject tunaStand;

    // Start is called before the first frame update
    void Start()
    {
        switch(levelCounter)
        {
            case 1:
                totalGameTime = 60;
                sushiPlate.SetActive(true);
                SushiRollSigns.SetActive(true);
                break;
            case 2:
                totalGameTime = 50;
                tunaStand.SetActive(true);
                tunaCutscene.Play();                
                //disable salmon in fridge, seaweed and other stuff
                seaweed.SetActive(false);
                salmon.SetActive(false);
                //turn on instruction signs
                SushiRollSigns.SetActive(false);
                tunaNigiriSigns.SetActive(true);
                //enable tunaPlate
                tunaPlate.SetActive(true);
                break;
            case 3:
                totalGameTime = 45;
                sushiPlate.SetActive(true);
                SushiRollSigns.SetActive(true);
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
            sushiPlate.SetActive(true);
            return;
        }

        if (tunaCutscene.state != PlayState.Playing)
        {
            totalGameTime -= Time.deltaTime;       
            //sets GameCountdown's text to rounded number of totalGameTime
             gameCountdown.text = Mathf.Round(totalGameTime).ToString();
        }
  
    
        if (totalGameTime <= 0)
        {   //loads lose scene
            SceneManager.LoadScene("RanOutOfTime(Lose)");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gameCursor.SetActive(false);
        }
    }
}
