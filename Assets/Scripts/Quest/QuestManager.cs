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
        if(instance!=null){
            Debug.LogWarning("Found more than one Quest Manager in the scene");
        }
        instance = this;
        
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

    //public Quest CurrentQuest { get; set; }
    //private Quest handle;
    public QuestInfo[] QuestLists;
    public int QuestAvailiable = 99;

    // what if no argument?
    public void displayAcceptQuestUI(int QID)
    {
        //display accept window
        QuestAcceptUI.SetActive(true);
        questAName.text = QuestLists[QID].QuestName;
        questADescription.text = QuestLists[QID].description;
        questAProgress.text = QuestLists[QID].Todo;
        questAReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
        //Add quest to player
        PlayerOwnQuest.GetInstance().QuestID = QuestLists[QID].QuestID;
        PlayerOwnQuest.GetInstance().QuestType = QuestLists[QID].QuestType;
        PlayerOwnQuest.GetInstance().QuestName = QuestLists[QID].QuestName;
        PlayerOwnQuest.GetInstance().description = QuestLists[QID].description;
        PlayerOwnQuest.GetInstance().Todo = QuestLists[QID].Todo;
        PlayerOwnQuest.GetInstance().RequiredAmount = QuestLists[QID].RequiredAmount;
        PlayerOwnQuest.GetInstance().expReward = QuestLists[QID].expReward;
        PlayerOwnQuest.GetInstance().recoinReward = QuestLists[QID].recoinReward;
        PlayerOwnQuest.GetInstance().itemReward = QuestLists[QID].itemReward;
    }

    public void displayQuestUIonClear(int QID)
    {
        QuestOnClearUI.SetActive(true);
        questCName.text = QuestLists[QID].QuestName;
        questCDescription.text = QuestLists[QID].description;
        questCProgress.text = QuestLists[QID].Todo;
        questCReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
        AddQuestRewardOnClear();
        QuestPlayerOwn();
    }

    public void AddQuestRewardOnClear(){
        //this function contains adding reward to player
        Debug.Log("Adding Reward");
        //exp and inventory
    }

    public void QuestPlayerOwn(){
        //call after adding quest reward
    }
    /*
    public void displayQuestonUI(int QID){
        QuestUI.SetActive(true);
        questName.text = QuestLists[QID].QuestName;
        questDescription.text = QuestLists[QID].description;
        questProgress.text = QuestLists[QID].Todo;
        questReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
    }
    */

    public static QuestManager GetInstance()
    {
        return instance;
    }

    public void FindQuestAvailiable(){
        Debug.Log("Quests in list = "+QuestLists.Length);
        for(int i=QuestLists.Length-1; i>=0; i--){
            if(QuestLists[i].Accepted==false){
                QuestAvailiable = QuestLists[i].QuestID;
            }
        }
        Debug.Log("QuestID of first quest availiable is "+QuestAvailiable);
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
        public int RequiredAmount;
        //public int[] RequiredAmount;
        public int expReward;
        public int recoinReward;
        public string itemReward;

        // 0 as incompleted, 1 as complete
        public bool Accepted = false;
        public bool Completed;
    }
}