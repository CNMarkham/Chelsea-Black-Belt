using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : MonoBehaviour, ISwipeable
{
    public GameObject salmonToEnable;
    public void GetSwiped()
    {
        print("swiped 3");
        gameObject.SetActive(false);
        salmonToEnable.SetActive(true);
    }

}
