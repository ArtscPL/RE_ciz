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
    public GameObject PauseUI;
    public GameObject SaveMenu;
    public GameObject ConfirmMainMenu;
    public GameObject ConfirmQuite;
    
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

    public void ShowSaveUI(){
        SFXmanager.GetInstance().ButtonPressSound();
        SaveMenu.SetActive(true);
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
        SFXmanager.GetInstance().ButtonPressSound();
        Debug.Log("Sound Setto");
    }

    public void ClickMainMenu(){
        SFXmanager.GetInstance().ButtonPressSound();
        ConfirmMainMenu.SetActive(true);
    }

    public void ClickQuit(){
        SFXmanager.GetInstance().ButtonPressSound();
        ConfirmQuite.SetActive(true);
    }

    public void GoMenu()
    {
        SFXmanager.GetInstance().ButtonPressSound();
        SaveManager.GetInstance().DestroySaveManager();
        BossManager.GetInstance().DestroyBossManager();
        SceneManager.LoadScene("StartMenu");
        Debug.Log("Go to StartMenu");
    }

    public void QuickSave()
    {
        //press quit and it'll quick save for player
        SFXmanager.GetInstance().ButtonPressSound();
        Debug.Log("Quick Save and Quit");
        Application.Quit();
    }

    public void callSoundClick(){
        SFXmanager.GetInstance().ButtonPressSound();
    }

    
}
