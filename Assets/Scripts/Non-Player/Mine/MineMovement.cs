using UnityEngine;

public class MineMovement : MonoBehaviour
{
    private float speed = 1.7f;
    Rigidbody2D mineRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        mineRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        float zRotation = Random.Range(1, 360);
        //Converting from the Int Random range gives us to a float for our vector 

        Vector3 rotatedVector = new Vector3(0, 0, zRotation);
        //Creating a vector at relative position 0,0, zRotation, where Z will be our rotation
        transform.Rotate(rotatedVector);

        //Roating to a random position to change appearances 
    }

    // Static Backward movement
    void FixedUpdate()
    {
        mineRigidbody2D.velocity = new Vector2(0f - speed, 0f);
        //Sets the speed to the X direction of a velocity vector


    }
}
