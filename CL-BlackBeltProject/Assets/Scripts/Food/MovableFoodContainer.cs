using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableFoodContainer: MonoBehaviour
{
    public GameObject[] VisibleFoods;
    public GameObject confetti;
    // Update is called once per frame
    void Update()
    {
        //check for 4 game objects to see if they are enabled
        //if the game objects are enabled, change layer to pickup layer
        if (VisibleFoods[0].activeSelf && VisibleFoods[1].activeSelf && VisibleFoods[2].activeSelf && VisibleFoods[3].activeSelf)
        {   
            //sets the layer to pickup layer so it is possible to pick up
            gameObject.layer = 6;
            confetti.SetActive(true);
        }
    }
}
