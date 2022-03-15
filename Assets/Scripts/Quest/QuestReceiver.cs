using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestReceiver : MonoBehaviour
{
    public static QuestReceiver instance;

    public QuestBase quest;
    public Playercontrol player;

    public ButtonControl Bcon;
    public Text QName;
    public Text QDescription;
    public Text QTodo;
    public Text QReward;
    public Transform questHolder;
    public GameObject questButtonPrefab;

    private void Awake()
    {
        if (instance != null) instance = this;
    }


    public void OpenQuestWindow()
    {
        Bcon.Quest();
        //quest = newQuest;
        //QuestWindow.SetActive(true);
        //QName.text = newQuest.QuestName;
        //QDescription.text = newQuest.description;
        //QReward.text = "EXP +" + newQuest.expReward.ToString() + ", " + "ReCoin +" + newQuest.recoinReward.ToString() + "\n" + newQuest.itemReward;
    }

    public void UpdateQuestUI(QuestBase newQuest)
    {
        quest = newQuest;
        QName.text = quest.QuestName;
        QDescription.text = quest.description;
        QTodo.text = quest.todo;
        QReward.text = "EXP +" + quest.expReward.ToString() + ", " + "ReCoin +" + quest.recoinReward.ToString() + "\n" + quest.itemReward;
    }

    public void AddQuestToLog(QuestBase newQuest)
    {
        var questButton = Instantiate(questButtonPrefab,questHolder);

        questButton.GetComponent<QuestButton>().SetQuest(newQuest);
        /*quest = newQuest;
        QName.text = quest.QuestName;
        QDescription.text = quest.description;
        QTodo.text = quest.todo;
        QReward.text = "EXP +" + quest.expReward.ToString() + ", " + "ReCoin +" + quest.recoinReward.ToString() + "\n" + quest.itemReward;*/
    }

}
