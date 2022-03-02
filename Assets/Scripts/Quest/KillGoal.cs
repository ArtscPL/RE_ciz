using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoal : QuestGoal
{
    public int EnemyID { get; set; }

    public KillGoal(Quest quest,int enemyID, string description,string todo,bool completed,int currentAmount,int requireAmount)
    {
        this.Quest = quest;
        this.EnemyID = enemyID;
        this.Description = description;
        this.Todo = todo;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requireAmount;
    }

    public override void Init()
    {
        base.Init();
        //add combat events on enemydeath += enemydied
    }
    
    //need function Script
    void EnemyDied(IEnemy enemy)
    {
        if (enemy.ID == this.EnemyID)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
}
