using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleFoodMovement : MonoBehaviour
{
    private float speed;
    Rigidbody2D littleFoodRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        littleFoodRigidBody = gameObject.GetComponent<Rigidbody2D>();
        speed = Random.Range(1.3f, 1.7f);
    }

    // Static Backward movement
    void FixedUpdate()
    { 
        littleFoodRigidBody.velocity = new Vector2(0f - speed, 0f);
    }
}
