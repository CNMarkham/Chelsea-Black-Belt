using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : MonoBehaviour, IChoppable
{
    public GameObject salmonToEnable;
    public void GetChopped()
    {
        print("swiped 3");
        gameObject.SetActive(false);
        salmonToEnable.SetActive(true);
    }

}
