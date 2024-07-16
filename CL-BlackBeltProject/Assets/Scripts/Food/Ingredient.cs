using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient: MonoBehaviour
{
    public GameObject toEnable;
    public string triggerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggerTag)
        {
            toEnable.SetActive(true);
            Destroy(gameObject);
        }
    }
}
