using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;

    // Checking consistently for user input by frames
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameMangaerScript.Instance.gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }
    public void Pause()
    {
        //We are enabling our pause menu UI by  setting it to active
        pauseMenuUI.SetActive(true);

        //This method is super cool, we can basically control how fast relative objects and calculations are done.  

        GameMangaerScript.Instance.gameIsPaused = true;
    }

    public void Resume()
        //Unpauses game
    {
        pauseMenuUI.SetActive(false);

        GameMangaerScript.Instance.gameIsPaused = false;

    }
    public void MainMenu()
        //Returns to main menu, unpauses game
    {
        pauseMenuUI.SetActive(false);
        GameMangaerScript.Instance.gameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }
}
