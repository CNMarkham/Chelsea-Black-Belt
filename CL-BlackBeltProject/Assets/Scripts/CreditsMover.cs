using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMover : MonoBehaviour
{
    public float speed = 45;
    // Start is called before the first frame update
    void Start()
    {
        //makes "DelayedSceneLoader" happen after 1 minute
        Invoke("DelayedSceneLoader", 60f);
    }

    // Update is called once per frame
    void Update()
    {
        //moves the credits text up
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void DelayedSceneLoader()
    {
        SceneManager.LoadScene("Menu");
    }
}
