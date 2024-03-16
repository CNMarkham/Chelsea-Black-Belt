using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    public static int levelCounter = 0;
    public Text GameCountdown;
    public float totalGameTime;
    // Start is called before the first frame update
    void Start()
    {
        if (levelCounter == 2)
        {
            totalGameTime = 60;
        }

        else if (levelCounter == 4)
        {
            totalGameTime = 50;
        }

        else if (levelCounter == 6)
        {
            totalGameTime = 45;
        }

        else if (levelCounter > 6)
        {
            totalGameTime = 30;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if (levelCounter == 0)
        {
            GameCountdown.text = "";
            return;
        } 

        totalGameTime -= Time.deltaTime;        
        GameCountdown.text = Mathf.Round(totalGameTime).ToString();       

        if (totalGameTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
