using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideManager : MonoBehaviour
{
    public static GuideManager instance;
    private void Awake(){
       if(instance!=null){
            Debug.Log("We only need 1 guide manager on a scene");
        }
        instance = this;
       DontDestroyOnLoad(gameObject);
    }

    public void DestroyMeSenpai(){
       Destroy(gameObject);
    }

    public static GuideManager GetInstance(){
        return instance;
    }

    public bool KarenCallForManager(){
        return true;
    }
}
