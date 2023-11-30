using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
