using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestReceiverNPC : MonoBehaviour
{
    [Header("Quest Avaliable")]
    [SerializeField] public GameObject QuestAcceptUI;
    //from GameGrind
    [SerializeField] private string questType;
    [SerializeField] public GameObject quests;


    /*public Text questName;
    public Text questDescription;
    public Text questTodo;
    public Text questReward;*/

    public Quest Quest { get; set; }
    public QuestDetail[] QuestList;
    
    private void Start()
    {
        // use for granting quest
    }

    //from this is irrelevant
    //private Quest killwolf;

    private void Update()
    {
        bool Quest101Accepted = ((Ink.Runtime.BoolValue)DialogueManager
            .GetInstance()
            .GetVariableState("questAccepted")).value;

        //quest accept window popup after end of dialogue and assigned quest
        if (Quest101Accepted && Input.GetKeyDown(KeyCode.Space))
        {
            
            //Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));
            if(QuestList.Length != 0){
                Quest.QuestName = QuestList[0].QuestName;
                Quest.description = QuestList[0].description;
                Quest.Todo = QuestList[0].Todo;
                Quest.expReward = QuestList[0].expReward;
                Quest.recoinReward = QuestList[0].recoinReward;
                Quest.itemReward = QuestList[0].itemReward;
            }
            Debug.Log("Quest Added");

            //move this to other blank script for setUI especially 
            QuestManager.instance.setQuestUI(questType);
            // for a bool value
            DialogueManager.GetInstance().SetVariableState("questAccepted", new Ink.Runtime.BoolValue(false));
        }

        /*if (Quest.Completed)
        {
            Quest.GiveReward();
        }*/
    }

    private void UpdateQuestUI(){

    }
    
    [System.Serializable]
    public class QuestDetail {
        public string QuestName;
        public string description;
        public string Todo;
        public int expReward;
        public int recoinReward;
        public string itemReward;
        public bool Completed;
    }

}
