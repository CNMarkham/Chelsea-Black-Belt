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
            hiddenSalmonBoxCutscene.Play();
            HiddenSalmonBox();
        }

        if (GameTime.levelCounter == 5 && salmonBox.activeSelf)
        {
            HiddenSalmonBox();
        }
    }

    void HiddenSalmonBox()
    {
        poof.SetActive(true);
        salmonBox.SetActive(false);
        var randomPos = hiddenSalmonBoxes[Random.Range(0, hiddenSalmonBoxes.Length)];
        randomPos.SetActive(true);
    }
}
