using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestButton : MonoBehaviour
{
    [HideInInspector] public QuestBase myQuest;
    public TextMeshProUGUI questNameText;

    public void SetQuest(QuestBase newQuest)
    {
        myQuest = newQuest;
        questNameText.text = newQuest.QuestName;
    }
}
