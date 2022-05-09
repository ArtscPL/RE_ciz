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
    private void Awake()
    {
        if(instance!=null){
            Debug.LogWarning("Found more than one PlayerOwnQuest in the scene");
        }
        instance = this;
        
    }

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

    //there are quests with many needs
    public int RequiredAmount;
    //public int[] RequiredAmount;
    public int expReward;
    public int recoinReward;
    public string itemReward;
    // 0 as incompleted, 1 as complete
    //public bool Accepted = false;
    public bool Completed = false;


    public void ClearQuestOnPlayer(){

    }

    public void displayQuestonUI(){
        QuestUI.SetActive(true);
        questName.text = QuestName;
        questDescription.text = description;
        questProgress.text = Todo;
        questReward.text = "EXP +" + expReward.ToString() + ", " + "ReCoin +" + recoinReward.ToString() + "\n" + itemReward;
    }
}
