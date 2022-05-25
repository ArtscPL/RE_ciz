using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{   
    public AudioSource Audio;
    public AudioClip Click;
    public static SFXmanager instance;

    private void Awake(){
        if (instance!=null){
            Debug.Log("Found more than 1 sfx manager here");      
        }
        instance = this;              
    }

    public static SFXmanager GetInstance(){
        return instance;
    }

    public void ButtonPressSound(){
        Audio.PlayOneShot(Click);
    }
}
