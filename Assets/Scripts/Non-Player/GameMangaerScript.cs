using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangaerScript : MonoBehaviour
{


    #region Singleton
    //This just lets us collapse the area

    public static GameMangaerScript Instance;

    private void Awake()
        //Happens before game start, should be used when passing references between scripts (Like our pools)
    {
        Instance = this;
        //Sets the Game Script Manager Instance to this singleton class

        DontDestroyOnLoad(gameObject);
        //Prevents this game object from being destroyed when we load a new scene
    }


    #endregion

    public bool gameIsPaused=false;

    [System.Serializable]
    //Lets us mutate the class in Unity
    public class Pool
    //Creating a custom object pool class with three atributes (name, prefab, and size)
    {
        public string poolName;
        public GameObject prefab;
        public int poolSize;
    }

    public List<Pool> pools;
    // Creating a list of our created class each with its own size, prefab and name
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    // We are creating a dictionary of object pools from which we can spawn a bunch of objects 

    public int score =0;
    public int playerHealth = 5;            
    // Start is called before the first frame update

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        // Creates a Dictionary for our pools, a Dictionary basically is just pairing a type of object (in this case, our Queues of game objects) with a word (our string)
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            //Generating the pools, this makes a new empty Queue

            for (int i = 0; i < pool.poolSize; i++)
                //Runs through each pool a number of times equal to their size
            {
                GameObject tempObj = Instantiate(pool.prefab);
                tempObj.SetActive(false);
                objectPool.Enqueue(tempObj);                
                //Creates an object in the queue, sets it initially to false, and enqueues it (puts it at the back of the queue)
            }
            poolDictionary.Add(pool.poolName, objectPool);
        }
        if (Time.timeScale!= 1)
        {
            Time.timeScale = 1;
        }
    }

    

    private void Update()
    {
        //Managing our win/loss conditions
        if (playerHealth <= 0)
        {
            
        }
        if (score >= 75)
        {
            
        }

        //Running our pause through the game manager
        if (gameIsPaused == true)
        {
            Time.timeScale = 0f;
        }
        if (gameIsPaused == false)
        {
            Time.timeScale = 1f;
        }

    }


    public GameObject SpawnFromPool (string tag, Vector3 position, Quaternion rotation)
        //How we actually spawn objects, automatically will requeue them after awhile
    {

        GameObject objectSpawn = poolDictionary[tag].Dequeue();
        //Takes the oldest object in the pool

        objectSpawn.SetActive(true);
        //Sets it from false to true if false 

        objectSpawn.transform.position = position;
        //Spawns object at passed in position
        objectSpawn.transform.rotation = rotation;
        //Spawns object at passed in rotation


        poolDictionary[tag].Enqueue(objectSpawn);
        //Adds it back to the beginning of the queue

        return objectSpawn;

    }



}
