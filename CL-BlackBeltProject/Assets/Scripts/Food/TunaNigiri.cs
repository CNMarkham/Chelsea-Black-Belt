using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunaNigiri : MonoBehaviour
{
    public GameObject rice;      
    public GameObject rice2;
    public GameObject rice3;
    public GameObject tuna;
    public GameObject tuna2;
    public GameObject tuna3;
    public GameObject[] tunaNigiris;
    public ParticleSystem poof;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (rice.activeSelf && tuna.activeSelf)
        {
            rice.SetActive(false);
            tuna.SetActive(false);
            poof.Play();           
            tunaNigiris[0].SetActive(true);

        }
        if (rice2.activeSelf && tuna2.activeSelf)
        {
            rice2.SetActive(false);
            tuna2.SetActive(false);
            poof.Play();
            tunaNigiris[1].SetActive(true);

        }
        if (rice3.activeSelf && tuna3.activeSelf)
        {
            rice3.SetActive(false);
            tuna3.SetActive(false);
            poof.Play();
            tunaNigiris[2].SetActive(true);

        }
    }
}