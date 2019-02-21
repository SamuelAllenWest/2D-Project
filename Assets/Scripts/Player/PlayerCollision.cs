using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour


{
    public GameObject mineExplosion;
    public GameObject fishBubbles;

    public Animator playerAnimator;
    //Manages player animations
    
    bool hasntDied = true;


    void Update()
    {
        
        if (GameMangaerScript.Instance.playerHealth <= 0 && hasntDied == true)
        {
            hasntDied = false;
            PlayerDies();
        }

    }

    private void PlayerDies()
    {
        playerAnimator.SetBool("IsDead", true);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Mine")
        {


            GameMangaerScript.Instance.playerHealth -= 1;
            //Deincrement Player Health
            col.gameObject.SetActive(false);
            //Set collision object ot false
            GameMangaerScript.Instance.poolDictionary["minePool"].Enqueue(col.gameObject);
            //Place the object back in the queue

            Instantiate(mineExplosion, col.gameObject.transform.position, col.gameObject.transform.rotation);

          

        }

        if (col.gameObject.tag == "LittleFood")
        {

            //I'll leave this here and empty just in case I need it later or want to switch to everything working this way


        }
        if (col.gameObject.tag == "BigFood")
        {


            GameMangaerScript.Instance.score += 3;
            //Big Food is worth 3
            col.gameObject.SetActive(false);
            //Set collision object ot false
            GameMangaerScript.Instance.poolDictionary["bigFoodPool"].Enqueue(col.gameObject);
            //Place the object back in the queue
            Instantiate(fishBubbles, col.gameObject.transform.position, col.gameObject.transform.rotation);
            //Should make a fish bubbles animation on collision where the now deactivated game object used to be    


        }



    }   
}
