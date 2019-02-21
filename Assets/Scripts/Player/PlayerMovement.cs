using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRigidBody;
    // RigidBody2D variable we will assign to be self here to work with the RigidBody physics engine to define player movement
    public float speed;
    // A public variable we can mutate outside of this file, determines how fast the player moves 

    float xSpeed;
    float ySpeed;




    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = gameObject.GetComponent<Rigidbody2D>();
        // This is setting our RigidBody variable to the gameObject's (the object which this script is a Component for)
    }

    // FixedUpdate is called after a fixed amount of time, regardless of frames 
    void FixedUpdate()
    {
        xSpeed = 0;
        ySpeed = 0;
 
        //Initaiting our Speeds inside our method so they reset on fixed update to 0. Is it better practice to iniate outside, so we can edit everywhere?

        if (Input.GetKey(KeyCode.W))
        {
            ySpeed = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ySpeed = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            xSpeed = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xSpeed = 1;
        }

        playerRigidBody.velocity = new Vector2(xSpeed, ySpeed) * speed;
        // Sets a velocity to be applied to our player with a determined speed in the x and y directions based on user input

        //Determines Player Movement Boundaries 

        Vector2 currentPosition = transform.position;
        //This creates a 2D vector of our current position every fixed update

        currentPosition.x = Mathf.Clamp(currentPosition.x, 0f, 15f);
        //.x assigns X cooridnate to a Vector
        //Clamp checks if a number is within a range then if not sets it to be either the max or min in that range

        currentPosition.y = Mathf.Clamp(currentPosition.y, 0.8f, 9f);
        //.x assigns X cooridnate to a Vector, locks to screen positions 

        transform.position = currentPosition;
        //Resets our position to be a valid poisition within the bounds

    }
}
