using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public float timechange = 0;
    public Animator transition;
    public float transitionTime = 1f;
    void Update()
    {    
        timechange += Time.deltaTime;
        if(timechange>=25){
            SceneManager.LoadScene("Test Dialogue");
            StartCoroutine(LoadScene());
        } 
    }
    IEnumerator LoadScene(){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
