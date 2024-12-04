using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunaNigiri : MonoBehaviour
{
    public GameObject rice;
    public GameObject tuna;
    public ParticleSystem poof;
    public GameObject[] tunaNigiris;
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
          
            //enable 1 of the 3 nigiris in the array
            if (counter == 0)
            {
                tunaNigiris[0].SetActive(true);
                counter += 1;
            }          
            //enable a different one
            else if (counter == 1)
            {
                tunaNigiris[1].SetActive(true);
                counter += 1;
            }
            else if (counter == 2)
            {
                tunaNigiris[2].SetActive(true);
            }
        }
    }
}