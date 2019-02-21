using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleFoodCollisionTrigger : MonoBehaviour
{
    public GameObject deathAnimationPrefab;


    // How we're handling running into the little food, differs from big food because I like big food interacting with mines
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            GameMangaerScript.Instance.score += 1;
            //Little food is worth 1 point


            gameObject.SetActive(false);
            //Set little food object to false
            GameMangaerScript.Instance.poolDictionary["littleFoodPool"].Enqueue(gameObject);
            //Place the object back in the queue


            Instantiate(deathAnimationPrefab, gameObject.transform.position, gameObject.transform.rotation);
            

        }
    }
}
