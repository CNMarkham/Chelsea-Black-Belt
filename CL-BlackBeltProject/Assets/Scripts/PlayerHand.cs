using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public Transform cam;

    private LayerMask pickupLayer;
    private Rigidbody heldPickup;
    private float heldDistance;
    // Start is called before the first frame update
    void Start()
    {
        pickupLayer = LayerMask.GetMask("Pickup");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //check if there is any items to pickup
            //if there is an item, pickup the item
            if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, 1, pickupLayer))
            {
                hit.rigidbody.isKinematic = true;
                heldPickup = hit.rigidbody;
                heldDistance = (hit.transform.position - cam.position).magnitude;
            }
        }

        if (heldPickup != null)
        {
            heldPickup.transform.position = cam.position + cam.forward * heldDistance;
        }
    }
}
