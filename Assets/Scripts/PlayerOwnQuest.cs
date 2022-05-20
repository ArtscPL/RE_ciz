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
    public int QuestIDTracking = 0;
    public int QuestID;
    public int QuestType;
    public string QuestName;
    public string description;
    public string Todo;

    public int EnemyID;
    //there are quests with many needs
    public int CurrentAmount = 0;
    public int RequiredAmount = 99;
    //public int[] RequiredAmount;
    public int expReward;
    public int recoinReward;
    public string itemReward;

    public string Vcomplete;
    //public string Vdone;
    // 0 as incompleted, 1 as complete
    //public bool Accepted = false;
    public bool Completed = false;
    public Item ItemComplete;
    
    private void Awake()
    {
        if(instance!=null){
            Debug.LogWarning("Found more than one PlayerOwnQuest in the scene");
        }
        instance = this;
        QuestManager.GetInstance().ClearPlayerOwn();
    }
    private void Update() {
        //QuestManager.GetInstance().FindQuestAvailiable();
        if(QuestID != 0 && CurrentAmount==RequiredAmount && Completed == false){
            QuestTurnin();
            //ClearQuestOnPlayer();
        }
    }

    public void UpdateCurrentAmount(int MonID){
        if(EnemyID==MonID){
            CurrentAmount++;
        }
    }

    public void QuestTurnin(){
        //Debug.Log("Can turn-in current quest");
        DialogueManager.GetInstance().SetVariableState(Vcomplete, new Ink.Runtime.BoolValue(true));
        NotiUI.SetActive(true);
        NotiText.text = "คุณสามารถส่งภารกิจ " +QuestName+ " ได้แล้ว";
        Completed = true;
    }

    public void displayQuestonUI(){
        QuestUI.SetActive(true);
        questName.text = QuestName;
        questDescription.text = description;
        questProgress.text = Todo;
        questReward.text = "EXP +" + expReward.ToString() + ", " + "ReCoin +" + recoinReward.ToString() + "\n" + itemReward;
    }
}
