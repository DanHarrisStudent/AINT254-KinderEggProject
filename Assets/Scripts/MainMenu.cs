using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        //Load the next scene in que
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
<<<<<<< HEAD

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
=======
>>>>>>> 28b0f7f157a47bced5a6a34055e35eda370428d1
}
