using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient: MonoBehaviour
{
    public GameObject toEnable;
    public string triggerTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggerTag)
        {
            toEnable.SetActive(true);
            Destroy(gameObject);
        }

    }
}
