using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    public Text GameCountdown;
    public float totalGameTime;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        totalGameTime -= Time.deltaTime;        
        GameCountdown.text = Mathf.Round(totalGameTime).ToString();       

        if (totalGameTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
