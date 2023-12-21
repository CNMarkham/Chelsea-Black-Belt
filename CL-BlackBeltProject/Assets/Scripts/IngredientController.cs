using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : MonoBehaviour
{

    public GameObject rice;
    public GameObject noriPrefab;
    public GameObject salmonCutPrefab;

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
        if (other.gameObject.tag == "HoldableRice")
        {
            if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                rice.SetActive(true);
                Destroy(other.gameObject);           
            }


        }
        if (other.gameObject.tag == "Nori")
        {
            if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                noriPrefab.SetActive(true);
                Destroy(other.gameObject);
            }

        }
        if (other.gameObject.tag == "SalmonCut")
        {
            if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                salmonCutPrefab.SetActive(true);
                Destroy(other.gameObject);
            }

        }

    }
}
