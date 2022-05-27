using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTrigger : MonoBehaviour
{
    public GameObject GuideUi;

    public static GuideTrigger instance;

    private void Awake(){
        if(instance!=null){
            Debug.Log("We only need 1 guide trigger on a scene");
        }
        instance = this;
        GuideManager gm = GuideManager.GetInstance();
        if(gm!=null){
            Character.GetInstance().GTrigger = true;
            Debug.Log(Character.GetInstance().GTrigger);
            GuideUi.SetActive(true);
            GuideManager.GetInstance().DestroyMeSenpai();
        }
    }

    public static GuideTrigger GetInstance(){
        return instance;
    }

}
