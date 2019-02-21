using UnityEngine;

public class MineSpawn : MonoBehaviour
{
    float delay = 1.2f;
    // Delay between spawns
    float countdown = 1f;
    //Variable we use to track spawns
    public GameObject minePrefab;
    //Loading in the prefab we want to be spawning 

    float escalation = 10f;

    public Transform[] spawnPoints;
    //Getting an array of positions to set as our spawn points for our Instantiation, eventually will be object pool

    int lastRn = 0;
    //This is a variable we're going to use to reduce the number of times mines spawn in the same row



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnMine();
            //Method making mines
            countdown = delay;
            //Resets our countdown
        }


        else
        {
            countdown -= Time.deltaTime;
            //Subtracts the time thats passed from our countdown towards next spawn
        }

        if (escalation <= 0f && delay>=0.4f)
        // Reducing the spawn timer of mines to increase difficulty over time, capping out at spawning an new mine every half second
        {
            delay -= 0.1f;
            escalation = 20f;

        }
        else if (delay>=0.3f)
        //Will stop tracking escalation once delay has reached minimum 
        {
            escalation -= Time.deltaTime;
        }


    }
    void SpawnMine()
    {
        int rn = Random.Range(0, spawnPoints.Length);
        //Generating a random number from 0 to the length of our array 
        //Need data type to be int for array locations 


        if (lastRn == rn)
        {
            rn = Random.Range(0, spawnPoints.Length);
        }

        Transform spawnPoint = spawnPoints[rn];
        //Getting our specific 
        lastRn = rn;
        //Setting our variable for next instance to reduce redundancy 

        GameMangaerScript.Instance.SpawnFromPool("minePool", spawnPoint.position, spawnPoint.rotation);
        // Goes to our game manager script and grabs a mine from our pool to spawn at the given positions with a set rotation



    }

}
