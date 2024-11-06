using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunaNigiri : MonoBehaviour
{
    public GameObject rice;
    public GameObject tuna;
    public GameObject poof;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rice.activeSelf && tuna.activeSelf)
        {
            rice.SetActive(false);
            tuna.SetActive(false);
            poof.SetActive(true);
            gameObject.SetActive(true);
        }
    }
}
