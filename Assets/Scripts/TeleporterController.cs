using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleporterController : MonoBehaviour
{
    public GameObject TPwindow;
    public Button Button1;
    public TextMeshProUGUI text1;
    public Button Button2;
    public TextMeshProUGUI text2;
    public Button Button3;
    public TextMeshProUGUI text3;
    public Button Button4;
    public TextMeshProUGUI text4;
    public Button Button5;
    public TextMeshProUGUI text5;
    private bool playerInRange;

    public Animator transition;
    public float transitionTime = 1f;
    public static TeleporterController instance;

    void Awake(){
        playerInRange = false;
        TPwindow.SetActive(false);
        Button b1 = Button1.GetComponent<Button>();
		b1.onClick.AddListener(Click1);
        Button b2 = Button2.GetComponent<Button>();
		b2.onClick.AddListener(Click2);
        Button b3 = Button3.GetComponent<Button>();
		b3.onClick.AddListener(Click3);
        Button b4 = Button4.GetComponent<Button>();
		b4.onClick.AddListener(Click4);
        Button b5 = Button5.GetComponent<Button>();
		b5.onClick.AddListener(Click5);
    }

    void Update()
    {
        if(playerInRange){
            DisplayUI();
        }
        else{
            TPwindow.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    private void DisplayUI(){
        TPwindow.SetActive(true);
        if(SceneManager.GetActiveScene().name == "Centriana"){
            text1.text = "Slopakia";
            text2.text = "Foretina";
            text3.text = "Probocean";
            text4.text = "Cavectar";
            text5.text = "Magmatos";
        }
        else if(SceneManager.GetActiveScene().name == "Slopakia"){
            text1.text = "Centriana";
            text2.text = "Foretina";
            text3.text = "Probocean";
            text4.text = "Cavectar";
            text5.text = "Magmatos";
        }
        else if(SceneManager.GetActiveScene().name == "Foretina"){
            text1.text = "Centriana";
            text2.text = "Slopakia";
            text3.text = "Probocean";
            text4.text = "Cavectar";
            text5.text = "Magmatos";
        }
        else if(SceneManager.GetActiveScene().name == "Probocean"){
            text1.text = "Centriana";
            text2.text = "Slopakia";
            text3.text = "Foretina";
            text4.text = "Cavectar";
            text5.text = "Magmatos";
        }
        else if(SceneManager.GetActiveScene().name == "Cavectar"){
            text1.text = "Centriana";
            text2.text = "Slopakia";
            text3.text = "Foretina";
            text4.text = "Probocean";
            text5.text = "Magmatos";
        }
        else if(SceneManager.GetActiveScene().name == "Magmatos"){
            text1.text = "Centriana";
            text2.text = "Slopakia";
            text3.text = "Foretina";
            text4.text = "Probocean";
            text5.text = "Cavectar";
        }
        else{
            text1.text = "Centriana";
            text2.text = "Slopakia";
            text3.text = "Foretina";
            text4.text = "Probocean";
            text5.text = "Cavectar";
        }
    }

    public void Click1(){
        if (text1.text == "Centriana"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Centriana");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Centriana");
            StartCoroutine(LoadScene());
        }
        else if (text1.text == "Slopakia"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Slopakia");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Slopakia");
            StartCoroutine(LoadScene());
        }
        else{
            Debug.Log("Input Error");
        }
    }

    public void Click2(){
        if (text2.text == "Slopakia"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Slopakia");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Slopakia");
            StartCoroutine(LoadScene());
        }
        else if (text2.text == "Foretina"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Foretina");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Foretina");
            StartCoroutine(LoadScene());
        }
        else{
            Debug.Log("Input Error");
        }
    }

    public void Click3(){
        if (text3.text == "Foretina"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Foretina");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Foretina");
            StartCoroutine(LoadScene());
        }
        else if (text3.text == "Probocean"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Probocean");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Probocean");
            StartCoroutine(LoadScene());
        }
        else{
            Debug.Log("Input Error");
        }
    }

    public void Click4(){
        if (text4.text == "Probocean"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Probocean");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Probocean");
            StartCoroutine(LoadScene());
        }
        else if (text4.text == "Cavectar"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Cavectar");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Cavectar");
            StartCoroutine(LoadScene());
        }
        else{
            Debug.Log("Input Error");
        }
    }

    public void Click5(){
        if (text5.text == "Cavectar"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Cavectar");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Cavectar");
            StartCoroutine(LoadScene());
        }
        else if (text5.text == "Magmatos"){
            Debug.Log("from " + SceneManager.GetActiveScene().name + " TP to Magmatos");
            MoveData.UseTP++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            SceneManager.LoadScene("Magmatos");
            StartCoroutine(LoadScene());
        }
        else{
            Debug.Log("Input Error");
        }
    }

    IEnumerator LoadScene(){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
