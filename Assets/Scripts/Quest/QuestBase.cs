using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBase : ScriptableObject
{
    public string QuestName;
    [TextArea(5, 10)]
    public string description;
    public string todo;
    public int expReward;
    public int recoinReward;
    public string itemReward;

    public int[] CurrentAmount { get; set; }
    public int[] RequiredAmount { get; set; }

    public bool IsCompleted { get; set; }

    public GameObject NPCTurnIn;

    public virtual void InitializeQuest()
    {
        //IsCompleted = false;
        CurrentAmount = new int[RequiredAmount.Length];
        //problem cause here
        //QuestReceiver.instance.AddQuestToLog(this);
    }

    public void Evaluate()
    {
        for(int i=0; i < RequiredAmount.Length; i++)
        {
            if (CurrentAmount[i] < RequiredAmount[i])
            {
                return;
            }
        }
        //add popup or change variable here
        IsCompleted = true;
        Debug.Log("Quest is Completed");
    }
}
