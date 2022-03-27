using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Intro");
        StartCoroutine(LoadScene());
    }

    public void QuitGame()
    {
        Debug.Log("QUIT BUTTON PRESSED!");
        Application.Quit();
    }

    IEnumerator LoadScene(){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
