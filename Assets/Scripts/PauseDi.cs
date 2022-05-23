using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDi : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public ButtonControl Bcon;
    public static PauseDi instance;
    public PlayerProfile pprofile;
    
    void Awake(){
        //PlayerProfile pprofile = player.GetComponent<PlayerProfile>();
        if (instance != null)
        {
            Debug.LogWarning("Found more than one PauseDi in the scene");
        }
        instance = this;
        //initialize inventory
        Bcon.Inventory();
        Bcon.Inventory();
    }
    
    public static PauseDi GetInstance()
    {
        return instance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&!ChestControl.GetInstance().triggerUI)
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

        if (Input.GetKeyDown(KeyCode.M)&&!ChestControl.GetInstance().triggerUI)
        {
            Bcon.Map();
        }

        if (Input.GetKeyDown(KeyCode.Q)&&!ChestControl.GetInstance().triggerUI)
        {
            Bcon.Quest();
            //PlayerOwnQuest.GetInstance().displayQuestonUI();
        }

        if (Input.GetKeyDown(KeyCode.I)&&!ChestControl.GetInstance().triggerUI)
        {
            Bcon.Inventory();
        }

        if (Input.GetKeyDown(KeyCode.C)&&!ChestControl.GetInstance().triggerUI)
        {
            Bcon.Profile();
            //might be changed 
            //pprofile.ProfileUIchanged();
        }

        if (Input.GetKeyDown(KeyCode.H)&&!ChestControl.GetInstance().triggerUI)
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
