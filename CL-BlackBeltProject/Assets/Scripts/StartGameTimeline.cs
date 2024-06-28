using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StartGameTimeline : MonoBehaviour
{
    public PlayableDirector timeline;
    // Start is called before the first frame update
    void Start()
    {
        if (GameTime.levelCounter == 0)
        {
            timeline.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
