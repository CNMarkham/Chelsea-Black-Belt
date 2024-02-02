using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiRoll : MonoBehaviour, ISwipeable
{
    public GameObject rice;
    public GameObject noriPrefab;
    public GameObject thinSalmonPrefab;
    private bool alreadyCut;

    public void GetSwiped()
    {
        if (rice.activeSelf && noriPrefab.activeSelf && thinSalmonPrefab.activeSelf)
        {
            rice.SetActive(false);
            noriPrefab.SetActive(false);
            thinSalmonPrefab.SetActive(false);
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
