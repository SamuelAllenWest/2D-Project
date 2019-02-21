using UnityEngine;

public class BigFoodMovement : MonoBehaviour
{
    private float speed;
    Rigidbody2D bigFoodRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bigFoodRigidbody = gameObject.GetComponent<Rigidbody2D>();
        speed = Random.Range(0.5f, 1f);
    }

    // Static Backward movement
    void FixedUpdate()
    {
        bigFoodRigidbody.velocity = new Vector2(0f - speed, 0f);
    }
}
