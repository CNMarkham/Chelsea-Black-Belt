using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableFoodContainer: MonoBehaviour
{
    public GameObject[] VisibleFoods;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for 4 game objects to see if they are enabled
        //if the game objects are enabled, change layer to pickup layer
        for (int i = 0; i <= 4; i += 1)
        {

        }
        gameObject.layer = 6;
    }
}
