using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public Transform cam;
    public GameObject rice;

    private LayerMask pickupLayer;
    private LayerMask tableLayer;
    private LayerMask riceLayer;
    private Rigidbody heldPickup;
    private float heldDistance;
    // Start is called before the first frame update
    void Start()
    {
        pickupLayer = LayerMask.GetMask("Pickup");
        tableLayer = LayerMask.GetMask("Table");
        riceLayer = LayerMask.GetMask("Rice");

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
            else if (Physics.Raycast(cam.position, cam.forward, 1, riceLayer)) // Supposed to instantiate rice when interacting with the rice bowl given a rice layer
            {
                Debug.Log("rice");
                Instantiate(rice, transform, false);
            }

            
        }
        if (Input.GetKey("e")) // Supposed to drop held food item if the player is looking at a table layer it can put food on
        {
            if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, 1, tableLayer) && heldPickup != null)
            {
                Debug.Log("held");
                hit.rigidbody.isKinematic = false;
                heldPickup = null;
            }
        }



            if (heldPickup != null)
        {
            heldPickup.transform.position = cam.position + cam.forward * heldDistance;
        }

        
    }
}
