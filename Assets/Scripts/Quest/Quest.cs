using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;

    public string QuestName;
    public string description;
    public int expReward;
    public int recoinReward;
    public string itemReward;
}
