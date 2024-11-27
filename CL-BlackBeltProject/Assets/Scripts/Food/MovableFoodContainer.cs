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
        for (int i = 0; i < VisibleFoods.Length; i++)
        {
            if (!VisibleFoods[i].activeSelf)
            {
                return;
            }
        }
        //sets the layer to pickup layer so it is possible to pick up
        gameObject.layer = 6;
        confetti.SetActive(true);
    }
}
