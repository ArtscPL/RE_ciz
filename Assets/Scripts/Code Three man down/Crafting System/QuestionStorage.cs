using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuestionStorage : MonoBehaviour
{
    //create only QuestionStorage 1 per scene , as a child in GameManager
    public static QuestionStorage instance;
    public QStorage[] storage;
    public GameObject RateUpUI;
    public Text QuestionText;
    public Text AnswerText1;
    public Button Button1;
    public Text AnswerText2;
    public Button Button2;
    public Text AnswerText3;
    public Button Button3;
    public Text AnswerText4;
    public Button Button4;
    public int chooseAnswer;
    public int IndexOnActive;

    //get this variable to double rate 
    //when want to use , call this command: bool x = QuestionStorage.GetInstance().GuessRight;
    public bool GuessRight = false;

    void Awake(){
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Question Storage in the scene");
        }
        instance = this;
        //Add listener to each button so we can track player decision
        Button b1 = Button1.GetComponent<Button>();
		b1.onClick.AddListener(Choice1);
        Button b2 = Button2.GetComponent<Button>();
		b2.onClick.AddListener(Choice2);
        Button b3 = Button3.GetComponent<Button>();
		b3.onClick.AddListener(Choice3);
        Button b4 = Button4.GetComponent<Button>();
		b4.onClick.AddListener(Choice4);
    }
    public static QuestionStorage GetInstance()
    {
        return instance;
    }

    public int GetQuestion(){
        int index = Random.Range(0,storage.Length);
        Debug.Log("Question Index:"+index);
        return index;
    }

    public void Choice1(){
        chooseAnswer = 1;
        Debug.Log("Choose :"+chooseAnswer);
        GuessRight = CheckAns(chooseAnswer);
        RateUpUI.SetActive(false);
    }
    public void Choice2(){
        chooseAnswer = 2;
        Debug.Log("Choose :"+chooseAnswer);
        GuessRight = CheckAns(chooseAnswer);
        RateUpUI.SetActive(false);
    }
    public void Choice3(){
        chooseAnswer = 3;
        Debug.Log("Choose :"+chooseAnswer);
        GuessRight = CheckAns(chooseAnswer);
        RateUpUI.SetActive(false);
    }
    public void Choice4(){
        chooseAnswer = 4;
        Debug.Log("Choose :"+chooseAnswer);
        GuessRight = CheckAns(chooseAnswer);
        RateUpUI.SetActive(false);
    }

    public bool CheckAns(int choose){
        if(storage[IndexOnActive].Correct == choose){
            Debug.Log("Correct!");
            SFXmanager.GetInstance().EpicWin();
            return true;
        }
        else{
            SFXmanager.GetInstance().CallNope();
            return false;
        }
    }

    public void RateUpPopUp(){
        RateUpUI.SetActive(true);
        IndexOnActive = GetQuestion();
        QuestionText.text = storage[IndexOnActive].question;
        AnswerText1.text = storage[IndexOnActive].choice1;
        AnswerText2.text = storage[IndexOnActive].choice2;
        AnswerText3.text = storage[IndexOnActive].choice3;
        AnswerText4.text = storage[IndexOnActive].choice4;
    }
}

[System.Serializable]
public class QStorage{
    public string question = "";
    public string choice1 = "";
    public string choice2 = "";
    public string choice3 = "";
    public string choice4 = "";
    public int Correct = 0;
}

