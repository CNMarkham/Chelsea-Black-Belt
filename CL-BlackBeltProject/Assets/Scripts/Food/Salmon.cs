using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : MonoBehaviour, ISwipeable
{
    public GameObject salmonToEnable;
    public void GetSwiped()
    {
        gameObject.SetActive(false);
        salmonToEnable.SetActive(true);
    }
}
