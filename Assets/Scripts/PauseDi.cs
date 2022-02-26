using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDi : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public GameObject PauseMenuUI;
    public GameObject QuestUI;
    public GameObject MapUI;
    public GameObject InventoryUI;

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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (MapUI.active)
            {
                MapUI.SetActive(false);
            }
            else
            {
                MapUI.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (QuestUI.active)
            {
                QuestUI.SetActive(false);
            }
            else
            {
                QuestUI.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryUI.active == true)
            {
                InventoryUI.SetActive(false);
            }
            else
            {
                InventoryUI.SetActive(true);
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

    public void SoundSetting()
    {
        Debug.Log("Sound Setto");
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
