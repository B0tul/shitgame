using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float speed;
    public float speedoriginal;
    public float rotatespeed;
    public float rotatespeedoriginal;

    // Start is called before the first frame update
    void Start()
    {
        speedoriginal = speed;
        rotatespeedoriginal = rotatespeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) // up
        {
            myRigidbody.velocity = transform.TransformVector(new Vector3(0, 1, 0)) * speed;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) == true) // up (disable)
        {
            myRigidbody.velocity = transform.TransformVector(new Vector3(0, 0, 0)) * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow) == true) // down
        {
            myRigidbody.velocity = transform.TransformVector(new Vector3(0, -1, 0)) * speed;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) == true) // down (disable)
        {
            myRigidbody.velocity = transform.TransformVector(new Vector3(0, 0, 0))  * speed;
        }


        if (Input.GetKey(KeyCode.RightArrow) == true) // right
        {
            myRigidbody.transform.Rotate(0.0f, 0.0f, - rotatespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true) // left
        {
            myRigidbody.transform.Rotate(0.0f, 0.0f, rotatespeed * Time.deltaTime);
        }
        // if (Input.GetKeyDown(KeyCode.LeftShift) == true) // sprint
        // {
        //     speed = speed * 2;
        //     rotatespeed = (float)(rotatespeed * 1.5); // not sure why it has to be done like this, but otherwise Unity complains
        // }
        // if (Input.GetKeyUp(KeyCode.LeftShift) == true) // sprint (disable)
        // {
        //     speed = speedoriginal;
        //     rotatespeed = rotatespeedoriginal;
        // }

        
        myRigidbody.angularVelocity = 0; // fix for the circle infinitly rotating after hitting a wall

    }
}
