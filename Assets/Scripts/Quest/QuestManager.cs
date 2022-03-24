using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public GameObject QUEST;
    public Quest newQuest { get; set; }

    public GameObject QuestUI;
    public GameObject QuestOnClearUI;
    //public TextMeshProUGUI questState;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;

    public Quest CurrentQuest { get; set; }
    private Quest handle;
    private GameObject handleG;

    // what if no argument?
    public void setQuestUI(string N)
    {
        //Quest newQuest = gameObject.GetComponent<N>();
        //handle = GameObject.Find("Quests").GetComponent<Quest101>();
        handleG = GameObject.Find("Quests");
        //handleG.GetComponent<Quest101>().expReward;
        //Quest CurrentQuest = GetComponent<Quest101>() as Quest;
        //Debug.Log("CurrentQuest = "+ CurrentQuest);
        Debug.Log("Quest = " + N);
        if (handleG != null) Debug.Log("this is not null");
        else Debug.Log("this is null");
        Debug.Log(handleG.name);
        newQuest = handleG.GetComponent<Quest>();
        QuestUI.SetActive(true);
        questName.text = newQuest.QuestName;
        questDescription.text = newQuest.description;
        questProgress.text = newQuest.Todo;
        questReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }

    public void setQuestUIonClear(QuestBase newQuest)
    {
        QuestOnClearUI.SetActive(true);
        questName.text = newQuest.QuestName;
        questDescription.text = newQuest.description;
        questProgress.text = newQuest.todo;
        questReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }
}