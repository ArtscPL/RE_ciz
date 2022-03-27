using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDi : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public ButtonControl Bcon;
    public QuestReceiver QR;

    public PlayerProfile pprofile;
    
    /*void Awake(){
        PlayerProfile pprofile = player.GetComponent<PlayerProfile>();
    }
    */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Zawarudo();
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Bcon.Map();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Bcon.Quest();
            //QR.OpenQuestWindow();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Bcon.Inventory();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Bcon.Profile();
            //might be changed 
            pprofile.ProfileUIchanged();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Bcon.Hint();
        }

    }

    void Zawarudo()
    {
        Debug.Log("ZAWARUDO!");
        Bcon.Setting();
        IsGamePaused = true;
    }

    void Resume()
    {
        Debug.Log("Hoho~");
        Bcon.Setting();
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
        Application.Quit();
    }

    
}
