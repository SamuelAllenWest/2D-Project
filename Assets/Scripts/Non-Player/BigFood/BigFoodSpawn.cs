using UnityEngine;

public class BigFoodSpawn : MonoBehaviour
{
    private float countdown = 3f;
    //Variable we use to track spawns
    public GameObject littleFoodPrefab;
    //Loading in the prefab we want to be spawning 

    public Transform[] spawnPoints;
    //Getting an array of positions to set as our spawn points for our Instantiation
    private int lastRn = 0;
    //This is a variable we're going to use to reduce the number of times mines spawn in the same row


    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnFood();
            //Goes and makes some fish
            countdown = Random.Range(7f,9f);
            //Resets our countdown
        }


        else
        {
            countdown -= Time.deltaTime;
            //Subtracts the time thats passed from our countdown towards next spawn
        }


    }
    void SpawnFood()
    {
        int rn = Random.Range(0, spawnPoints.Length);
        //Generating a random number from 0 to the length of our array 
        //Need data type to be int for array locations 

        if(rn == lastRn)
        //Reduces chances of spawning twice in the same spawn area
        {
            rn = Random.Range(0, spawnPoints.Length);
        }

        Transform spawnPoint = spawnPoints[rn];
        //Getting our specific 

        GameMangaerScript.Instance.SpawnFromPool("bigFoodPool", spawnPoint.position, spawnPoint.rotation);
        // Goes to our game manager script and grabs a mine from our pool to spawn at the given positions 
            



        lastRn = rn;
    }

}