using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LossMenu : MonoBehaviour
{
    public GameObject loseMenuUI;

    void Update()
    {

        if (GameMangaerScript.Instance.playerHealth <= 0)
        {
            Lose();

        }
    }
    public void Lose()
    {
        //We are enabling our pause menu UI by  setting it to active
        loseMenuUI.SetActive(true);

        GameMangaerScript.Instance.gameIsPaused = true;



    }

    public void Restart()
    {
        GameMangaerScript.Instance.gameIsPaused = false;

        loseMenuUI.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Reloads current level
         
    }
    public void MainMenu()
        //Takes us back to the main menu
    {

        loseMenuUI.SetActive(false);
        GameMangaerScript.Instance.gameIsPaused = false;
        SceneManager.LoadScene("Menu");


    }
}
