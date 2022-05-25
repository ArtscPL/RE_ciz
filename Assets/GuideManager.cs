using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideManager : MonoBehaviour
{
public GameObject GuideUI;
   private void Awake(){
       DontDestroyOnLoad(gameObject);
   }

   public void DestroyMeSenpai(){

   }
}
