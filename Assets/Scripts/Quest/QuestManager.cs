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
        questAReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString();
        if(QuestLists[QID].ItemInstance!=null){
            questAReward.text = questAReward.text + "\n" + QuestLists[QID].ItemInstance.ItemName;
        }
        //Add quest to player
        PlayerOwnQuest.GetInstance().QuestOwn = QuestLists[QID];
    }

    public void displayQuestUIonClear(int QID)
    {
        QuestOnClearUI.SetActive(true);
        questCName.text = QuestLists[QID].QuestName;
        questCDescription.text = QuestLists[QID].description;
        questCProgress.text = QuestLists[QID].Todo;
        questCReward.text = "EXP +" + QuestLists[QID].expReward.ToString() + ", " + "ReCoin +" + QuestLists[QID].recoinReward.ToString();
        if(QuestLists[QID].ItemInstance!=null){
            questAReward.text = questAReward.text + "\n" + QuestLists[QID].ItemInstance.ItemName;
        }
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
        if(PlayerOwnQuest.GetInstance().QuestOwn.ItemInstance != null){
            Character.GetInstance().Inventory.AddItem(PlayerOwnQuest.GetInstance().QuestOwn.ItemInstance);
            Debug.Log(PlayerOwnQuest.GetInstance().QuestOwn.ItemInstance+ " Added");
        }
        QuestLists[QID].Accepted = true;
        PlayerOwnQuest.GetInstance().QuestOwn = null;
    }
    /*
    public void ClearPlayerOwn(){
        //call after adding quest reward
        PlayerOwnQuest.GetInstance().QuestID = 0;
        PlayerOwnQuest.GetInstance().QuestType = 0;
        PlayerOwnQuest.GetInstance().QuestName = "หางานทำได้แล้ว";
        PlayerOwnQuest.GetInstance().description = "ขณะนี้ยังไม่ได้อยู่ในระหว่างการทำภารกิจ\nในตอนนี้สิ่งที่คุณต้องทำคือหายใจไปวันๆและรอตังจากขุ่นแม่";
        PlayerOwnQuest.GetInstance().Todo = "หิวก็กินข้าว หนาวก็ใส่เสื้อ เมื่อเป็นหวัด ทิฟฟี่แผงสีเขียว";
        PlayerOwnQuest.GetInstance().E_ID = 0;
        PlayerOwnQuest.GetInstance().RequiredAmount = 99;
        PlayerOwnQuest.GetInstance().expReward = 0;
        PlayerOwnQuest.GetInstance().recoinReward = 0;
        PlayerOwnQuest.GetInstance().itemReward = "";
        PlayerOwnQuest.GetInstance().Vcomplete = "";
        PlayerOwnQuest.GetInstance().Completed = false;
        PlayerOwnQuest.GetInstance().ItemComplete = null;
    }
    */

    public static QuestManager GetInstance()
    {
        return instance;
    }

    public void FindQuestAvailiable(){
        //Debug.Log("Quests in list = "+QuestLists.Length);
        
        int ID = PlayerOwnQuest.GetInstance().QuestIDTracking;
        /*for(int i=QuestLists.Length-1; i>=0; i--){
            if(QuestLists[i].Accepted==false){
                //QuestAvailiable = QuestLists[i].QuestID;
                QuestIndex = i;
            }
        }*/

        switch(ID){
            case 0:
                QuestAvailiable = 101;
                break;
            case 101:
                QuestAvailiable = 102;
                break;
            case 102:
                QuestAvailiable = 103;
                break;
            case 103:
                QuestAvailiable = 104;
                break;
            case 104:
                QuestAvailiable = 105;
                break;
            case 105:
                QuestAvailiable = 106;
                break;
            case 106:
                QuestAvailiable = 107;
                break;
            case 107:
                QuestAvailiable = 108;
                break;
            case 108:
                QuestAvailiable = 201;
                break;
            case 201:
                QuestAvailiable = 202;
                break;
            case 202:
                QuestAvailiable = 203;
                break;
            case 203:
                QuestAvailiable = 204;
                break;
            case 204:
                QuestAvailiable = 205;
                break;
            case 205:
                QuestAvailiable = 206;
                break;
            case 206:
                QuestAvailiable = 207;
                break;
            case 207:
                QuestAvailiable = 208;
                break;
            case 208:
                QuestAvailiable = 201;
                break;
            case 209:
                QuestAvailiable = 301;
                break;
            case 301:
                QuestAvailiable = 302;
                break;
            case 302:
                QuestAvailiable = 303;
                break;
            case 303:
                QuestAvailiable = 304;
                break;
            case 304:
                QuestAvailiable = 305;
                break;
            case 305:
                QuestAvailiable = 306;
                break;
            case 306:
                QuestAvailiable = 401;
                break;
            case 401:
                QuestAvailiable = 402;
                break;
            case 402:
                QuestAvailiable = 403;
                break;
            case 403:
                QuestAvailiable = 404;
                break;
            case 404:
                QuestAvailiable = 405;
                break;
            case 405:
                QuestAvailiable = 406;
                break;
            case 406:
                QuestAvailiable = 501;
                break;
            case 501:
                QuestAvailiable = 502;
                break;
            case 502:
                QuestAvailiable = 503;
                break;
            case 503:
                QuestAvailiable = 504;
                break;
            case 504:
                QuestAvailiable = 505;
                break;
            case 505:
                QuestAvailiable = 506;
                break;
            case 506:
                QuestAvailiable = 601;
                break;
            case 601:
                QuestAvailiable = 602;
                break;
            case 602:
                QuestAvailiable = 603;
                break;
            case 603:
                QuestAvailiable = 604;
                break;
            default:
                break;
        }
        /*Debug.Log("QuestID of first quest availiable is "+QuestAvailiable+
        " have Index = "+QuestIndex);*/
        for(int i=0;i<QuestLists.Length;i++){
            if(QuestLists[i].QuestID==QuestAvailiable){
                QuestIndex = i;
            }
        }
        //Debug.Log("Player can get Quest"+QuestAvailiable+"and index is"+QuestIndex);
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
        //public string itemReward;

        // 0 as incompleted, 1 as complete
        public bool Accepted = false;
        public string Vcomplete;
        //public string Vdone;
        public bool Completed;
        public Item ItemInstance;
    }
}