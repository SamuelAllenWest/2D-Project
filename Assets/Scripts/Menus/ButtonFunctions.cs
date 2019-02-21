using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We use this package for our scene switching and managing, I think its contained within the Engine
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void pressPlay()
    {
        // We are loading the scene named SampleScene from inside the project 
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadScene("Menu");
        //the Play button uses its parent's CS sheet and calls one of its functions, which is super user friendly in the editor. 10/10.
    }
    public void pressExit()
    {
        //NOTE: This function doesn't work in the Unity editor, but in as an application, will work. It just quits the application using the Quit function of the Application class (I think)
        Application.Quit();
    }

}
