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
    [Header("Quest Accept")]
    public GameObject QuestAcceptUI;

    public Text questAName;
    public Text questADescription;
    public Text questAProgress;
    public Text questAReward;
    [Header("Quest Clear")]
    public GameObject QuestOnClearUI;
    public Text questCName;
    public Text questCDescription;
    public Text questCProgress;
    public Text questCReward;
    [Header("Quest Windows")]
    public GameObject QuestUI;
    //public TextMeshProUGUI questState;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;

    //public Quest CurrentQuest { get; set; }
    //private Quest handle;
    public QuestInfo[] QuestLists;

    // what if no argument?
    public void displayAcceptQuestUI(int QID)
    {
        QuestAcceptUI.SetActive(true);
        questAName.text = QuestLists[QID].QuestName;
        questADescription.text = QuestLists[QID].description;
        questAProgress.text = QuestLists[QID].Todo;
        questAReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
    }

    public void displayQuestUIonClear(int QID)
    {
        QuestOnClearUI.SetActive(true);
        questName.text = QuestLists[QID].QuestName;
        questDescription.text = QuestLists[QID].description;
        questProgress.text = QuestLists[QID].Todo;
        questReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
        AddQuestReward_Player();
    }

    public void AddQuestReward_Player(){
        //this function contains adding reward to player
        //exp and inventory
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
        //QuestID should start with 1-6 and always
        //has 3 digits ex. 1xx, 3xx
        //using 0xx for testing
        public int QuestID;

        //QuestType = 1 for kill quest
        //QuestType = 2 for collect quest
        //QuestType = 3 for event quest
        public int QuestType;
        public string QuestName;
        public string description;
        public string Todo;

        //there are quests with many needs
        public int[] RequiredAmount;
        public int expReward;
        public int recoinReward;
        public string itemReward;

        // 0 as incompleted, 1 as complete
        public bool Completed;
    }
}