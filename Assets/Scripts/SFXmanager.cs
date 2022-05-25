using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{   
    public AudioSource Audio;
    public AudioClip Click;
    public AudioClip Lost;
    public AudioClip Attack;
    public AudioClip Victory;
    public AudioClip Ora;
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
        if(Click!=null)
        Audio.PlayOneShot(Click);
    }

    public void StarPlatinum(){
        if(Ora!=null)
        Audio.PlayOneShot(Ora);
    }

    public void LostSound(){
        if(Lost!=null)
        Audio.PlayOneShot(Lost);
    }

    public void PressAttack(){
        if(Attack!=null)
        Audio.PlayOneShot(Attack);
    }

    public void EpicWin(){
        if(Victory!=null)
        Audio.PlayOneShot(Victory);
    }
}
