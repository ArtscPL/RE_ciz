using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSoundSet : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject SoundSettingUI;
    public static BattleSoundSet instance;

    public void SoundSetting()
    {
        SFXmanager.GetInstance().ButtonPressSound();
        SoundSettingUI.SetActive(false);
        Debug.Log("Sound Setto");
    }

    private void Awake(){
        SoundSettingUI.SetActive(true);
        SoundSettingUI.SetActive(false);
    }

    private void Start(){
        SetVolumn(SaveManager.GetInstance().AudioVolume);
    }

    public static BattleSoundSet GetInstance(){
        return instance;
    }

    public void SetVolumn(float volumn){
        //Debug.Log(volumn);
        //audioMixer.SetFloat("volume", volumn);
        audioSource.volume = volumn;
    }
}
