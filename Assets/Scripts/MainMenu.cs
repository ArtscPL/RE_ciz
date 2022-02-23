using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Test Dialogue");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT BUTTON PRESSED!");
        //Application.Quit();
    }
}
