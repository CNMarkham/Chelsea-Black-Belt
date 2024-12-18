using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RandomSalmonBox : MonoBehaviour
{
    public GameTime gameTime;
    public GameObject salmonBox;
    public GameObject[] hiddenSalmonBoxes;
    public GameObject poof;
    public PlayableDirector hiddenSalmonBoxCutscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameTime.levelCounter == 3 && salmonBox.activeSelf)
        {
            poof.SetActive(true);           
            salmonBox.SetActive(false);            
            hiddenSalmonBoxCutscene.Play();
            var randomPos = hiddenSalmonBoxes[Random.Range(0, hiddenSalmonBoxes.Length)];
            randomPos.SetActive(true);
        }
    }
}
