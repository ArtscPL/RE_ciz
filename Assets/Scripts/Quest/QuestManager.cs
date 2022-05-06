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
    //public GameObject QUEST;
    //public Quest newQuest { get; set; }

    public GameObject QuestAcceptUI;
    public GameObject QuestOnClearUI;
    public GameObject QuestUI;
    //public TextMeshProUGUI questState;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;

    //public Quest CurrentQuest { get; set; }
    //private Quest handle;
    public QuestInfo QuestLists;

    // what if no argument?
    public void displayAcceptQuestUI(int QID)
    {
        //QuestAcceptUI.SetActive(true);
        //questName.text = newQuest.QuestName;
        //questDescription.text = newQuest.description;
        //questProgress.text = newQuest.Todo;
        //questReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }

    public void displayQuestUIonClear(int QID)
    {
        //QuestOnClearUI.SetActive(true);
        //questName.text = newQuest.QuestName;
        //questDescription.text = newQuest.description;
        //questProgress.text = newQuest.todo;
       // questReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }

    public void displayQuestonUI(int QID){
        QuestUI.SetActive(true);
    }

    public static QuestManager GetInstance()
    {
        return instance;
    }

    [System.Serializable]
    public class QuestInfo {
        public string QuestName;
        public string description;
        public string Todo;
        public int expReward;
        public int recoinReward;
        public string itemReward;
        public bool Completed;
    }
}