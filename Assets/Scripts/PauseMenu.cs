using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    [SerializeField]
    private GameObject MenuUI;

    private bool IsPaused = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            MenuUI.SetActive(true);
            IsPaused = true;
        }

        else if (Input.GetKey(KeyCode.Escape) && IsPaused == true)
        {
            Time.timeScale = 1;
            MenuUI.SetActive(false);
            IsPaused = false;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
