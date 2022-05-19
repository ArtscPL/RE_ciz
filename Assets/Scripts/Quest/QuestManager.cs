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
    [Header("Quest Lists and Index")]

    //public Quest CurrentQuest { get; set; }
    //private Quest handle;
    public QuestInfo[] QuestLists;
    public int QuestAvailiable = 99;
    public int QuestIndex = 99;

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
        PlayerOwnQuest.GetInstance().EnemyID = QuestLists[QID].EnemyID;
        PlayerOwnQuest.GetInstance().RequiredAmount = QuestLists[QID].RequiredAmount;
        PlayerOwnQuest.GetInstance().expReward = QuestLists[QID].expReward;
        PlayerOwnQuest.GetInstance().recoinReward = QuestLists[QID].recoinReward;
        PlayerOwnQuest.GetInstance().itemReward = QuestLists[QID].itemReward;
        PlayerOwnQuest.GetInstance().Vcomplete = QuestLists[QID].Vcomplete;
        //PlayerOwnQuest.GetInstance().Vdone = QuestLists[QID].Vdone;
    }

    public void displayQuestUIonClear(int QID)
    {
        QuestOnClearUI.SetActive(true);
        questCName.text = QuestLists[QID].QuestName;
        questCDescription.text = QuestLists[QID].description;
        questCProgress.text = QuestLists[QID].Todo;
        questCReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString() + "\n" + QuestLists[QID].itemReward;
        PlayerOwnQuest.GetInstance().QuestIDTracking = QuestLists[QID].QuestID;
        AddQuestRewardOnClear(QID);
        //ClearPlayerOwn();
    }

    public void AddQuestRewardOnClear(int QID){
        //this function contains adding reward to player
        Debug.Log("Adding Reward");
        Character.GetInstance().PlayerExp+=QuestLists[QID].expReward;
        Character.GetInstance().Money+=QuestLists[QID].recoinReward;
        //item left
        QuestLists[QID].Accepted = true;
        //exp and inventory
    }

    public void ClearPlayerOwn(){
        //call after adding quest reward
        PlayerOwnQuest.GetInstance().QuestID = 0;
        PlayerOwnQuest.GetInstance().QuestType = 0;
        PlayerOwnQuest.GetInstance().QuestName = "หางานทำได้แล้ว";
        PlayerOwnQuest.GetInstance().description = "ขณะนี้ยังไม่ได้อยู่ในระหว่างการทำภารกิจ\nในตอนนี้สิ่งที่คุณต้องทำคือหายใจไปวันๆและรอตังจากขุ่นแม่";
        PlayerOwnQuest.GetInstance().Todo = "หิวก็กินข้าว หนาวก็ใส่เสื้อ เมื่อเป็นหวัด ทิฟฟี่แผงสีเขียว";
        PlayerOwnQuest.GetInstance().EnemyID = 0;
        PlayerOwnQuest.GetInstance().RequiredAmount = 99;
        PlayerOwnQuest.GetInstance().expReward = 0;
        PlayerOwnQuest.GetInstance().recoinReward = 0;
        PlayerOwnQuest.GetInstance().itemReward = "";
        PlayerOwnQuest.GetInstance().Vcomplete = "";
        PlayerOwnQuest.GetInstance().Completed = false;
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
        //Debug.Log("Quests in list = "+QuestLists.Length);
        for(int i=QuestLists.Length-1; i>=0; i--){
            if(QuestLists[i].Accepted==false){
                QuestAvailiable = QuestLists[i].QuestID;
                QuestIndex = i;
            }
        }
        /*Debug.Log("QuestID of first quest availiable is "+QuestAvailiable+
        " have Index = "+QuestIndex);*/
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
        public int EnemyID;
        //there are quests with many needs
        public int RequiredAmount;
        //public int[] RequiredAmount;
        public int expReward;
        public int recoinReward;
        public string itemReward;

        // 0 as incompleted, 1 as complete
        public bool Accepted = false;
        public string Vcomplete;
        //public string Vdone;
        public bool Completed;
    }
}