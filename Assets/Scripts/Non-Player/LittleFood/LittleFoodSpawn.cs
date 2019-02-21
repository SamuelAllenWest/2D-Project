using UnityEngine;

public class LittleFoodSpawn : MonoBehaviour
{
    float countdown = 0f;
    //Variable we use to track spawns

    public Transform[] spawnPoints;
    //Getting an array of positions to set as our spawn points for our Instantiation

    void Update()
        //On update, we check if we should spawn more fish on a semi-random timer
    {
        if (countdown <= 0f)
          
        {
            SpawnFood();
            //Goes and makes some fish
            countdown = Random.Range(2f, 3f);
            //Resets our countdown to a random number to change up spawn frequencies
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

        Transform spawnPoint = spawnPoints[rn];
        //Getting our specific coordiantes 
        GameMangaerScript.Instance.SpawnFromPool("littleFoodPool", spawnPoint.position, spawnPoint.rotation);
        // Goes to our game manager script and grabs a mine from our pool to spawn at the given positions 
    }

}
