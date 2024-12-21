using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneTrigger : MonoBehaviour
{
    private bool alreadyCollidedOnce;
    public GameObject popUpMenu;
    public Movement movement;
    public GameObject confetti;
    public GameObject gameCursor;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plate" && alreadyCollidedOnce == false)
        {
            confetti.SetActive(true);
            if (GameTime.levelCounter >= 4)
            {
                SceneManager.LoadScene("Win");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (GameTime.levelCounter == 0)
            {
                popUpMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                movement.enabled = false;
                gameCursor.SetActive(false); 
            }
            else
            {
                //increases level counter by 1
                GameTime.levelCounter++; 
                //sets alreadyCollidedOnce to true
                alreadyCollidedOnce = true; 
                //reloads the scene to the active scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
            } 
        }  

        if (other.tag == "TunaPlate" && alreadyCollidedOnce == false)
        {
            GameTime.levelCounter++;
            alreadyCollidedOnce = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
