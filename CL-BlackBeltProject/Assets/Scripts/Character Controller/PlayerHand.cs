using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public Transform cam;
    public GameObject ricePrefab;
    public WoodenBoardReciever woodenBoardReciever;
    public GameObject cutSalmonPrefab;
    public GameObject salmonPrefab;
    public float requiredDragDistance = -1f;

    private LayerMask choppableLayer;
    private LayerMask pickupLayer;
    private LayerMask defaultLayer;
    private Rigidbody heldPickup;
    private float heldDistance;
    private float recentMotion;

    private bool swipedDown;
    private bool canSwipeDown = true;
    void Start()
    {
        choppableLayer = LayerMask.GetMask("Choppable");
        pickupLayer = LayerMask.GetMask("Pickup", "Rice");
        defaultLayer = LayerMask.GetMask("Default");
    }

    void Update()
    {   
        //check if there is any items to pickup
        if (Input.GetMouseButtonDown(0) && heldPickup == null)
        {
            //if there is an item, pickup the item
            if (Physics.SphereCast(cam.position, 0.01f, cam.forward, out RaycastHit hit, 1, pickupLayer, QueryTriggerInteraction.Ignore))
            {
                //layer 8 is rice
                if (hit.collider.gameObject.layer == 8)
                {
                    heldPickup = Instantiate(ricePrefab).GetComponent<Rigidbody>();
                    heldPickup.isKinematic = true;
                    heldPickup.GetComponent<Collider>().enabled = false;
                    heldDistance = 0.5f;
                }
                else
                {
                    //when we pick up something, we don't want it to fall or anything, so make it kinematic
                    hit.rigidbody.isKinematic = true;
                    //we'll pick up things that have rigidbodies so that we can drop them and they'll have gravity and physics
                    heldPickup = hit.rigidbody;
                    //get the distance between our camera and the held object so we know exactly where to hold it later
                    heldDistance = (hit.transform.position - cam.position).magnitude;
                    hit.collider.enabled = false;
                    if (GameTime.levelCounter == 0)
                    {
                        if (hit.collider.gameObject.GetComponent<TutorialSalmon>() != null)
                        {
                            if (hit.collider.gameObject.GetComponent<TutorialSalmon>().played == false)
                            {
                                hit.collider.gameObject.GetComponent<TutorialSalmon>().cutscene1.Play();
                            }
                        }
                    }
                }    

            }        
        }
        //when we hold things, we want them to stay in our hands instead of being affected by gravity
        if(Input.GetMouseButtonDown(1) && heldPickup != null)
        {
            heldPickup.isKinematic = false; 
            foreach (Collider c in heldPickup.GetComponents<Collider>())
            {
                c.enabled = true;
            }
            heldPickup = null;
        }

        //heldpickup items will appear in front of the camera
        if (heldPickup != null)
        {
            //if it touches an object, it brings it closer to the camera
            if (Physics.SphereCast(cam.position, 0.1f, cam.forward, out RaycastHit hit, 1, defaultLayer))
            {

               if (hit.distance < heldDistance)
                {
                    heldDistance = hit.distance;
                }

               //sets heldDistance to 0.35f so that the object being held doesn't clip into the camera
               if (hit.distance < 0.35f)
                {
                     heldDistance = 0.35f;
                }
            }
                heldPickup.transform.position = cam.position + cam.forward * heldDistance;
        }

         swipedDown = CheckSwipeDown();

        //checks if swipedDown method has happened
        if (swipedDown)
        {
            //checks for an object with the choppableLayer in front of the camera
            if (Physics.BoxCast(cam.position, new Vector3(0.5f, 10f, 0.05f), cam.forward, out RaycastHit hitInfo, cam.rotation, 75f, choppableLayer, QueryTriggerInteraction.Collide))
            {
                hitInfo.transform.GetComponent<ISwipeable>().GetSwiped();
            }
        }

    }

    private bool CheckSwipeDown()
    {
        
        if (Input.GetMouseButton(0))
        {
            recentMotion += Input.GetAxisRaw("Mouse Y");
            //checks if recentMotion is less than requiredDragDistance and canSwipeDown
            if (recentMotion < requiredDragDistance && canSwipeDown)
            {
                recentMotion = 0;
                canSwipeDown = false;
                //sets swipedDown(line 100) to true
                return true;
            }
        }
        else 
        {
            canSwipeDown = true;
            recentMotion = 0;
        }
        //sets swipedDown to false
        return false;
    }
}