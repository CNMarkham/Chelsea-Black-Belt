using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineEnabler : MonoBehaviour
{
    public PlayableDirector cutscene;
    public GameObject[] otherObjects;
    private int objCount = 0;
    private void OnEnable()
    {
        //if all the salmon pieces are active then play cutscene

        if (GameTime.levelCounter == 0)
        {
            foreach (GameObject go in otherObjects)
            {
                if (go.activeSelf)
                {
                    objCount++;
                }
            }        
            if (objCount == otherObjects.Length)
            {
                cutscene.Play();
            }
        }
    }
}
