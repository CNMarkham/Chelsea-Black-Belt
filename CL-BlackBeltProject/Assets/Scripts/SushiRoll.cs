using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiRoll : MonoBehaviour, ISwipeable
{
    public GameObject rice;
    public GameObject noriPrefab;
    public GameObject thinSalmonPrefab;
    private int cutCounter;
    public GameObject sushiToEnable;
    public AudioSource rollingSound;

    public void GetSwiped()
    {
        if (cutCounter == 0)
        {
            if (rice.activeSelf && noriPrefab.activeSelf && thinSalmonPrefab.activeSelf)
            {
            rice.SetActive(false);
            noriPrefab.SetActive(false);
            thinSalmonPrefab.SetActive(false);
            GetComponent<MeshRenderer>().enabled = true;
            cutCounter += 1;
            }
        }

        else if (cutCounter == 1)
        {
            gameObject.SetActive(false);
            sushiToEnable.SetActive(true);
            rollingSound.Play();
        }


    }
}
