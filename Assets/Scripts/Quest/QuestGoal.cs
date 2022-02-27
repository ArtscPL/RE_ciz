using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal
{
    //public GoalType gt;
    //public string description;
    public int requiredAmount;
    public int currentAmount;
    public bool isCompleted;

    public virtual void Init()
    {
        //default init stuff
    }

    public void Evaluate()
    {
        if (currentAmount >= requiredAmount)
        {
            Complete();
        }
    }
    
    public void Complete()
    {
        isCompleted = true;
    }
}

/*public enum GoalType
{
    Kill,
    Gathering,
    Delivery
}*/