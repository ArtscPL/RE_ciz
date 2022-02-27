using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestReceiver : MonoBehaviour
{
    public Quest quest;
    public Playercontrol player;

    public ButtonControl Bcon;
    public Text QName;
    public Text QDescription;
    public Text QReward;

    public void OpenQuestWindow()
    {
        Bcon.Quest();
        //QuestWindow.SetActive(true);
        QName.text = quest.QuestName;
        QDescription.text = quest.description;
        QReward.text = "EXP +" + quest.expReward.ToString() + ", " + "ReCoin +" + quest.recoinReward.ToString() + "\n" + quest.itemReward + " x1";
    }
}
