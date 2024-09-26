using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBoardReciever : MonoBehaviour
{
    //salmon to be cut
    public GameObject salmonPrefab;
    //holds the cut salmon pieces
    public GameObject[] cutSalmonPieces;
    public bool isCuttingSalmon;
    public int salmonPiecesCut;

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
