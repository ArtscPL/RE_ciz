using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//[System.Serializable]
public class Quest : MonoBehaviour
{
    public List<QuestGoal> Goals { get; set; } = new List<QuestGoal>();
    //public bool isActive;

    public string QuestName { get; set; }
    public string description { get; set; }
    public string Todo { get; set; }
    public int expReward { get; set; }
    public int recoinReward { get; set; }
    public string itemReward { get; set; }
    public bool Completed { get; set; }

    public void CheckGoals()
    {
        Completed = Goals.All(g => g.Completed);
        //if (Completed) GiveReward();
    }

    public void GiveReward()
    {
        //add exp and recoin to player
        if (itemReward != null)
        {
            //add item to player's inventory
            Debug.Log("Adding Reward");
        }
    }
}
