using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenuUI;
    bool gameIsPaused;
    bool haveWon = false;

    void Update()
    {

        if ((GameMangaerScript.Instance.score >= 75) && haveWon==false)
            //Checks to see if you've won yet or not, will only display if you haven't 
        {
            Win();
            haveWon = true;
            //By setting this to true, it won't check for if you've won each time you increase the score

        }
    }
    public void Win()
    {
        //We are enabling our pause menu UI by  setting it to active
        winMenuUI.SetActive(true);

        GameMangaerScript.Instance.gameIsPaused = true;


    }

    public void Continue()
    {
        winMenuUI.SetActive(false);
        //Disables UI

        GameMangaerScript.Instance.gameIsPaused = false;

    }
    public void MainMenu()
    //Returns us to main menu
    {  
        winMenuUI.SetActive(false);
        GameMangaerScript.Instance.gameIsPaused = false;
        SceneManager.LoadScene("Menu");
        
        //Load the Menu Scene
    }
}
