using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        string pathI = Application.persistentDataPath + "/" + "Inventory" + ".dat";
        string pathE = Application.persistentDataPath + "/" + "Equipment" + ".dat";
        if(File.Exists(pathI))
        {
            File.Delete(pathI);
            File.Delete(pathE);
        }
        LoadSave.GetLoadManager().data = null;
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
