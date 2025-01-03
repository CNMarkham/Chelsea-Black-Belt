using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Movement movement;
    public GameObject pausedScreenMenu;
    public GameObject popUp;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausedScreenMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None; 
            movement.enabled = false;     
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pausedScreenMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        movement.enabled = true;         
        
        if (GameTime.levelCounter == 0 && popUp.activeSelf)
        {
            Time.timeScale = 1;
            pausedScreenMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            movement.enabled = false;
        }
    }

    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        GameTime.levelCounter = 0;
    }
}
