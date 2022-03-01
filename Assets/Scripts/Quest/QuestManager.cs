using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public GameObject QuestUI;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;

    /*public void setQuestUI(QuestBase newQuest)
    {
        QuestUI.SetActive(true);
        questName.text = newQuest.questName;
        questDescription.text = newQuest.questDescription;
        questProgress.text = newQuest.questProgress;
        questReward.text = newQuest.questReward;
    }*/
}
