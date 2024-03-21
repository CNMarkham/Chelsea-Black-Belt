using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneTrigger : MonoBehaviour
{
    private bool alreadyCollidedOnce;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Plate" && alreadyCollidedOnce == false)// and if it hasn't collided yet
        {
            if (GameTime.levelCounter == 4)
            {
                SceneManager.LoadScene(2);
            }
            else
                SceneManager.LoadScene(0);
            GameTime.levelCounter++;
            alreadyCollidedOnce = true;
        }  
    }
}
