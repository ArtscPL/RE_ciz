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


    public Text questName;
    public Text questDescription;
    public Text questTodo;
    public Text questReward;

    public Quest Quests { get; set; }
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
            Debug.Log(QuestList.Length);
            Debug.Log(QuestList[0].QuestName);
            /* null, this to be fixed
            if(Quests == null){
            Debug.Log("Null");
            }

            if(QuestList.Length != 0){
                Quests.QuestName = QuestList[0].QuestName;
                Quests.description = QuestList[0].description;
                Quests.Todo = QuestList[0].Todo;
                Quests.expReward = QuestList[0].expReward;
                Quests.recoinReward = QuestList[0].recoinReward;
                Quests.itemReward = QuestList[0].itemReward;
            }
            Debug.Log("Quest Added");
            */
            //QuestManager.instance.setQuestUI(QuestDetail[] QuestList);
            UpdateQuestUI();
            // for a bool value
            Quest101Accepted = false;
            DialogueManager.GetInstance().SetVariableState("questAccepted", new Ink.Runtime.BoolValue(false));
        }

        /*if (Quest.Completed)
        {
            Quest.GiveReward();
        }*/
    }

    private void UpdateQuestUI(){
        Debug.Log("UI Popup");
        QuestAcceptUI.SetActive(true);
        questName.text = QuestList[0].QuestName;
        questDescription.text = QuestList[0].description;
        questTodo.text = QuestList[0].Todo;
        questReward.text = "EXP +" + QuestList[0].expReward.ToString() + ", " + "ReCoin +" + QuestList[0].recoinReward.ToString() + "\n" + QuestList[0].itemReward;
    }
    
    [System.Serializable]
    public class QuestDetail {
        public int QuestID;
        public string QuestName;
        public bool Accepted = false;
        public string description;
        public string Todo;
        public int expReward;
        public int recoinReward;
        public string itemReward;   
        public bool Completed = false;
    }

}
