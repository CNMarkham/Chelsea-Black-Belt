using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineEnabler : MonoBehaviour
{
        public PlayableDirector cutscene; 

    private void OnEnable()
    {
        cutscene.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
