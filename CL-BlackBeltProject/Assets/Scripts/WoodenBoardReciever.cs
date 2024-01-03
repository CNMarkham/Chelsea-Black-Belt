using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBoardReciever : MonoBehaviour
{
    public GameObject salmonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Salmon")
        {
            if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                salmonPrefab.SetActive(true);
                Destroy(gameObject);
            }

        }
    }
}
