using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBase : ScriptableObject
{
    public string QuestName;
    [TextArea(5, 10)]
    public string description;
    public int expReward;
    public int recoinReward;
    public string itemReward;

    public int[] currentAmount { get; set; }
    public int[] requireAmount { get; set; }

    public bool IsCompleted { get; set; }
}
