using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBoardReciever : MonoBehaviour
{
    public GameObject salmonPrefab;

    public GameObject[] cutSalmonPieces;
    public bool isCuttingSalmon;
    public int salmonPiecesCut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CutSalmon()
    {
        if (cutSalmonPieces[3].activeSelf)
        {
            return;
        }
        cutSalmonPieces[salmonPiecesCut].SetActive(true);
        if (salmonPiecesCut > 0)
        {
            cutSalmonPieces[salmonPiecesCut-1].SetActive(false);
        }
        salmonPiecesCut+=1;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Salmon")
        {
            if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                salmonPrefab.SetActive(true);
                isCuttingSalmon = true;
                Destroy(other.gameObject);
            }

        }
    }
}
