using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public Transform cam;
    public GameObject ricePrefab;

    public static LayerMask pickupLayer;
    private LayerMask tableLayer;
    private LayerMask riceLayer;
    private Rigidbody heldPickup;
    private float heldDistance;
   
    void Start()
    {
        pickupLayer = LayerMask.GetMask("Pickup");
        tableLayer = LayerMask.GetMask("Table");
        riceLayer = LayerMask.GetMask("Rice");

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && heldPickup == null)
        {
            //check if there is any items to pickup
            //if there is an item, pickup the item
            if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, 1, pickupLayer))
            {
                //when we pick up something, we don't want it to fall or anything, so make it kinematic
                hit.rigidbody.isKinematic = true;
                //we'll pick up things that have rigidbodies so that we can drop them and they'll have gravity and physics
                heldPickup = hit.rigidbody;
                //get the distance between our camera and the held object so we know exactly where to hold it later
                heldDistance = (hit.transform.position - cam.position).magnitude;
            }
            else if (Physics.Raycast(cam.position, cam.forward, 1, riceLayer)) //instantiates rice when interacting with the rice bowl given a rice layer
            {
                heldPickup = Instantiate(ricePrefab).GetComponent<Rigidbody>();
                heldPickup.isKinematic = true;
                heldDistance = 0.5f;
            }            
        }
        if(Input.GetMouseButtonDown(1) && heldPickup != null)
        {
            heldPickup.isKinematic = false;
            heldPickup = null;

        }

        //heldpickup items will apear infront of the camera
        if (heldPickup != null)
        {
            heldPickup.transform.position = cam.position + cam.forward * heldDistance;
        }

        
    }
}
