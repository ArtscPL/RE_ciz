using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDi : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("ESC");
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Zawarudo();
            }
        }
    }

    void Zawarudo()
    {
        Debug.Log("ZAWARUDO!");
        PauseMenuUI.SetActive(true);
        IsGamePaused = true;
    }

    void Resume()
    {
        Debug.Log("Hoho~");
        PauseMenuUI.SetActive(false);
        IsGamePaused = false;
    }

    public void ReButt()
    {
        //deactive UI and back to normal
        Resume();
    }

    public void SaveInGame()
    {
        //Active other UI and let player save their progress
        Debug.Log("Save!");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Debug.Log("Go to StartMenu");
    }

    public void QuickSave()
    {
        //press quit and it'll quick save for player
        Debug.Log("Quick Save and Quit");
    }
}
