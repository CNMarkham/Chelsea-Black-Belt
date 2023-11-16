using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float moveHorizontal;
    float moveVertical;
    public Transform orientation;

    Vector3 movement;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void myInput()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void movePlayer()
    {
        movement = orientation.forward * moveVertical + orientation.right * moveHorizontal;
    }

    // Update is called once per frame
    void Update()
    {
        movement = movement * speed * Time.deltaTime;

        transform.position += movement;
    }
}
