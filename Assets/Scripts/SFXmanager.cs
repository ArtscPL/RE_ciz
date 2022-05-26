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
    public AudioClip onepunch;
    public AudioClip nope;
    public AudioClip OpenShop;
    public AudioClip Transactioncomplete;
    public AudioClip OpenCraft;
    public AudioClip Craft;
    public AudioClip NoMat;
    public AudioClip Guts;
    public static SFXmanager instance;

    private void Awake(){
        if (instance!=null){
            Debug.Log("Found more than 1 sfx manager here");      
        }
        instance = this;              
    }

    public void craftopen(){
        if(OpenCraft!=null)
        Audio.PlayOneShot(OpenCraft);
    }
    public void NotEnough(){
        if(NoMat!=null)
        Audio.PlayOneShot(NoMat);
    }
    public void WiseChoice(){
        if(Craft!=null)
        Audio.PlayOneShot(Craft);
    }
    public void RIPCraft(){
        if(Guts!=null)
        Audio.PlayOneShot(Guts);
    }

    public void transac(){
        if(Transactioncomplete!=null)
        Audio.PlayOneShot(Transactioncomplete);
    }
    public void shopopen(){
        if(OpenShop!=null)
        Audio.PlayOneShot(OpenShop);
    }

    public static SFXmanager GetInstance(){
        return instance;
    }

    public void ButtonPressSound(){
        if(Click!=null)
        Audio.PlayOneShot(Click);
    }

    public void ONEPANCHHH(){
        if(onepunch!=null)
        Audio.PlayOneShot(onepunch);
    }

    public void CallNope(){
        if(nope!=null)
        Audio.PlayOneShot(nope);
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
