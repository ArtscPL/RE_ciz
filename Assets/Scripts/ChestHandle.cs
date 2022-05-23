using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestHandle : MonoBehaviour
{
    // i should create a list for each box to delete itself which contain
    // question, answer ,reward and it own gameObject instance

    private static ChestHandle instance;
    public string answer { get; private set; }
    public InputField inputField;
    public bool ChestIsShowing {get; private set;}
    public Button buttClick;
    public Button RebuttClick;
    [SerializeField] public GameObject ChestUI;
    [SerializeField] private Text QuestionText;
    [SerializeField] public GameObject ChestRewardUI;
    [SerializeField] public Text Reward;
    public ChestInfo[] ChestLists;
    public int ChestIndex = 99;

    public static ChestHandle GetInstance()
    {
        return instance;
    }
    

    private void Awake(){
        ChestUI.SetActive(false);
        buttClick.onClick.AddListener(getAnswer);
        RebuttClick.onClick.AddListener(CloseRewardUI);
        if (instance!=null){
            Debug.LogWarning("Found more than ChestHandler in this scene");
        }
        instance = this;
        InitailizedChest();
    }
    
    public void UIDisplay(int ID){
        ChestIsShowing = true;
        ChestUI.SetActive(true);
        for(int i=0;i<ChestLists.Length;i++)
        {
            if(ID == ChestLists[i].ChestID){
                ChestIndex = i;
            }
            //ChestIndex = GameObject.Find(ChestName).GetComponent<ChestControl>();
        }
        Debug.Log("Index = " + ChestIndex);
        QuestionText.text = ChestLists[ChestIndex].ChestQuestion;
    }

    public void UIClosed(){
        ChestUI.SetActive(false);
        ChestIsShowing = false;
    }

    public void getAnswer(){
        //answer = inputField.GetComponent<Text>().text;
        answer = inputField.text;
        //Debug.Log(answer);
        CheckAnswer(answer,ChestLists[ChestIndex]);
    }

    public void InitailizedChest(){
        List<int> Solved = Character.GetInstance().ChestSolved;
        foreach(ChestInfo j in ChestLists){
            foreach(int i in Solved){
                if(j.ChestID==i){
                    Debug.Log(j.ChestID+" found to be solved");
                    j.ChestObject.SetActive(false);
                }
            }
        }
    }

    public void CheckAnswer(string ans,ChestInfo ChestL){
        //get a correct answer from list and check it with current input field that been
        // submitted
        if(ans==ChestL.ChestAnswer){
            Debug.Log(ChestL.ChestAnswer + " is a correct answer of this chest");
            //Debug.Log(ans + " is Correct~!!");
            Character.GetInstance().ChestUp();
            Character.GetInstance().ChestSolved.Add(ChestL.ChestID);
            ClearField();
            ChestRewardShowUp(ChestL); 
        }
        else
        {
            Debug.Log(ChestL.ChestAnswer + " is a correct answer of this chest");
            Debug.Log(ans + " is Wrong~, Try again");
            ClearField();
        }
    }

    public void ClearField(){
        inputField.text = "";
        answer = "Clear Text";
    }

    public void ChestRewardShowUp(ChestInfo ChestL){
        ChestRewardUI.SetActive(true); 
        Reward.text = "ReCoin + " + ChestL.recoinReward + "\n" + ChestL.itemReward + " x1";
        AddChestReward_Player(ChestL);
    }

    public void AddChestReward_Player(ChestInfo ChestL){
        //add Reward to player inventory
        if(ChestL.ItemInstance != null){
            Character.GetInstance().Inventory.AddItem(ChestL.ItemInstance);
            Debug.Log(ChestL.ItemInstance.ToString() +" Added");
        }
        Character.GetInstance().Money+=ChestL.recoinReward;
    }

    public void CloseRewardUI(){
        ChestRewardUI.SetActive(false);
        ChestUI.SetActive(false);
        ChestLists[ChestIndex].ChestObject.SetActive(false);
        //.SetActive(false);
        ChestIsShowing = false;
        ClearField();
    }

    [System.Serializable]
    public class ChestInfo{
        public int ChestID;
        public GameObject ChestObject;
        public string ChestQuestion;
        public string ChestAnswer;
        public int recoinReward;
        public string itemReward;
        public Item ItemInstance;
    }
}
