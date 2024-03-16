using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public Transform cam;
    public GameObject ricePrefab;
    public IngredientController ingredientController;
    public WoodenBoardReciever woodenBoardReciever;
    public GameObject cutSalmonPrefab;
    public GameObject salmonPrefab;
    public float requiredDragDistance = -1f;

    private LayerMask choppableLayer;
    private LayerMask pickupLayer;
    private LayerMask riceLayer;
    private Rigidbody heldPickup;
    private float heldDistance;
    private float recentMotion;

    private bool swipedDown;
    private bool canSwipeDown = true;


    void Start()
    {
        choppableLayer = LayerMask.GetMask("Choppable");
        pickupLayer = LayerMask.GetMask("Pickup");
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
                hit.collider.enabled = false;
            }
            else if (Physics.Raycast(cam.position, cam.forward, 1, riceLayer)) //instantiates rice when interacting with the rice bowl given a rice layer
            {
                heldPickup = Instantiate(ricePrefab).GetComponent<Rigidbody>();
                heldPickup.isKinematic = true;
                heldPickup.GetComponent<Collider>().enabled = false;
                heldDistance = 0.5f;
            }            
        }
        if(Input.GetMouseButtonDown(1) && heldPickup != null)
        {
            heldPickup.isKinematic = false; 
            heldPickup.GetComponent<Collider>().enabled = true;
            heldPickup = null;

        }

        //heldpickup items will apear infront of the camera
        if (heldPickup != null)
        {
            heldPickup.transform.position = cam.position + cam.forward * heldDistance;
        }

         swipedDown = CheckSwipeDown();

        if (swipedDown)
        {
            print("swiped");
            if (Physics.BoxCast(cam.position, new Vector3(10f, 10f, 0.05f), cam.forward, out RaycastHit hitInfo, cam.rotation, 75f, choppableLayer, QueryTriggerInteraction.Collide))
            {
                print("swiped 2");
                hitInfo.transform.GetComponent<ISwipeable>().GetSwiped();
            }
        }

    }

    private bool CheckSwipeDown()
    {
        
        if (Input.GetMouseButton(0))
        {
            recentMotion += Input.GetAxisRaw("Mouse Y");
            
            if (recentMotion < requiredDragDistance && canSwipeDown)
            {
                recentMotion = 0;
                canSwipeDown = false;
                return true;
            }
        }
        else 
        {
            canSwipeDown = true;
            recentMotion = 0;
        }
        return false;
    }
}