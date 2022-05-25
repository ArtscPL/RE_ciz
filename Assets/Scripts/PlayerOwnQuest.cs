using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOwnQuest : MonoBehaviour
{
    public static PlayerOwnQuest instance;
    [Header("Quest UI")]
    public GameObject QuestUI;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;
    public GameObject NotiUI;
    public Text NotiText;
    

    public static PlayerOwnQuest GetInstance()
    {
        return instance;
    }
    [Header("Quest Active")]
    public QuestManager.QuestInfo QuestOwn;
    public int QuestIDTracking = 0;
    public int CurrentAmount = 0;
    //public bool Completed = false;
    
    private void Awake()
    {
        if(instance!=null){
            Debug.LogWarning("Found more than one PlayerOwnQuest in the scene");
        }
        instance = this;
        
    }

    private void Start(){
        //QuestManager.GetInstance().ClearPlayerOwn();
    }

    private void Update() {
        //QuestManager.GetInstance().FindQuestAvailiable();
        if(QuestOwn != null){
            if(QuestOwn.QuestID != 0 && CurrentAmount==QuestOwn.RequiredAmount && QuestOwn.Completed == false){
            QuestTurnin();
            }
        }
        
    }

    public void UpdateCurrentAmount(int MonID){
        if(QuestOwn.EnemyID==MonID){
            CurrentAmount++;
            Debug.Log("added current amount");
        }
    }

    public void QuestTurnin(){
        //Debug.Log("Can turn-in current quest");
        DialogueManager.GetInstance().SetVariableState(QuestOwn.Vcomplete, new Ink.Runtime.BoolValue(true));
        NotiUI.SetActive(true);
        NotiText.text = "คุณสามารถส่งภารกิจ " +QuestOwn.QuestName+ " ได้แล้ว";
        QuestOwn.Completed = true;
    }

    public void displayQuestonUI(){
        QuestUI.SetActive(true);
        if(QuestOwn.QuestID!=0){
            questName.text = QuestOwn.QuestName;
            questDescription.text = QuestOwn.description;
            questProgress.text = QuestOwn.Todo + " (" + CurrentAmount + "/" + QuestOwn.RequiredAmount +")";
            questReward.text = "EXP +" + QuestOwn.expReward.ToString() + ", " + "ReCoin +" + QuestOwn.recoinReward.ToString();
            if(QuestOwn.ItemInstance != null){
                questReward.text = questReward.text  + "\n" + QuestOwn.ItemInstance.ItemName;
            }
        }
        else if(QuestOwn.QuestID==0){
            questName.text = "หางานทำได้แล้ว";
            questDescription.text = "ขณะนี้ยังไม่ได้อยู่ในระหว่างการทำภารกิจ\nในตอนนี้สิ่งที่คุณต้องทำคือหายใจไปวันๆและรอตังจากขุ่นแม่";
            questProgress.text = "หิวก็กินข้าว หนาวก็ใส่เสื้อ เมื่อเป็นหวัด ทิฟฟี่แผงสีเขียว";
            questReward.text = "มีชีวิตอยู่ไปวันๆ";
        }
    }
}
