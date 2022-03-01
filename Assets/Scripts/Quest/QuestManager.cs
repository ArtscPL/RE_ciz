using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject QuestUI;
    public Text questName;
    public Text questDescription;
    public Text questProgress;
    public Text questReward;

    public void setQuestUI(QuestBase newQuest)
    {
        QuestUI.SetActive(true);
        questName.text = newQuest.QuestName;
        questDescription.text = newQuest.description;
        questProgress.text = newQuest.todo;
        questReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }
}
