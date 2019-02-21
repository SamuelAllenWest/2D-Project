using UnityEngine;

//Sorry in advance for all the comments, they help learn by writing and give me clarity about even the basic stuff. 


public class ScrollingMovement : MonoBehaviour
{

    //f denotes its a float, not a double


    public float scrollSpeed = -0.5f;
    //We'll be assigning it an translate X direction and want to be able to mess with it in unity, thus public

    public float jumpDistance = 21.45f;
    //This is used to determine the float scroll max, which is deteremined by the size of our background 

    public float startPositionX = -20f;
    //Another mutable variable so we can adjust the starting position of our various scrolling objects


    Vector2 startPosition;
    //Creating a vecotr we'll be initializing in Start and resetting to later, used in multiple methods thus it goes outside of them




    // Start is called before the first frame update
    void Start()
    {

        transform.Translate(startPositionX, 0, 0);
        // We are starting it at -20 in the X direction, our ground level is set to 0 y

        startPosition = transform.position;
        //  We set this as our starting position 
    }

    // Using FixedUpdate so it always scrolls consistently, not based on frame rate
    void FixedUpdate()
    {
        float scroll = Mathf.Repeat(Time.time * scrollSpeed, jumpDistance);
        // We constantly generating a float from equal to the time of each frame times how fast we are scrolling and resetting it once we hit our jumpDistance

        transform.position = startPosition + Vector2.right * scroll;
        // Resets our joint background sprite pair, looks seemeless with the right math. Because of varied image sizes, I manually adjusted the speeds to add smoothness which lets this background scroller work for all my backgrounds and my floor. 


    }
}
