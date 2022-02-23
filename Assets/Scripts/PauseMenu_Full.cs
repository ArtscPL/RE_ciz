using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManager;

public class PauseMenu_Full : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC");
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }    
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        //Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        //insert change scene to StartMenu here
        //SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit...");
    }
}
