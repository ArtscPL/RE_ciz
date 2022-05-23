using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public static SaveManager saveManager;
    public int SaveCalled=0;
    public int SaveLV;
    public int SaveExp; 
    public int SaveMoney;
    //quest
    public QuestManager.QuestInfo SaveQuestOwn;
    public int SaveQTrack;
    public int SaveCurrentAmount;
    public List<int> SaveChestSolved = new List<int>();
    public int SaveChestUnlocked;
    public int SaveKillcount;
	public int SaveDeathC;
	public int SaveMaxDMG;
	public int SaveCraftEquip;
    public DialogueVariables SaveDialogueVariables;
    //public GameData datasaving;
    [SerializeField] public SaveSO SaveAsset;

    public void SaveGameData(){
        SaveLV = Character.GetInstance().PlayerLv;
        SaveExp = Character.GetInstance().PlayerExp;
        SaveMoney = Character.GetInstance().Money;
        SaveQuestOwn = PlayerOwnQuest.GetInstance().QuestOwn;
        SaveQTrack = PlayerOwnQuest.GetInstance().QuestIDTracking;
        SaveCurrentAmount = PlayerOwnQuest.GetInstance().CurrentAmount;
        SaveChestSolved = Character.GetInstance().ChestSolved;
        SaveChestUnlocked = Character.GetInstance().ChestUnlocked;
        SaveKillcount = Character.GetInstance().Killcount;
        SaveDeathC = Character.GetInstance().DeathC;
        SaveMaxDMG = Character.GetInstance().MaxDMG;
        SaveCraftEquip = Character.GetInstance().CraftEquip;
        SaveDialogueVariables = DialogueManager.GetInstance().dialogueVariables;
        SaveCalled++;
        Debug.Log("Save Called~");
    }

    public void LoadGameData(){
        Debug.Log("Load Called~");
        Character.GetInstance().PlayerLv = SaveLV;
        Character.GetInstance().PlayerExp = SaveExp;
        Character.GetInstance().Money = SaveMoney;
        PlayerOwnQuest.GetInstance().QuestOwn = SaveQuestOwn;
        PlayerOwnQuest.GetInstance().QuestIDTracking = SaveQTrack;
        PlayerOwnQuest.GetInstance().CurrentAmount = SaveCurrentAmount;
        Character.GetInstance().ChestSolved = SaveChestSolved;
        Character.GetInstance().ChestUnlocked = SaveChestUnlocked;
        Character.GetInstance().Killcount = SaveKillcount;
        Character.GetInstance().DeathC = SaveDeathC;
        Character.GetInstance().MaxDMG = SaveMaxDMG;
        Character.GetInstance().CraftEquip = SaveCraftEquip;
        DialogueManager.GetInstance().dialogueVariables = SaveDialogueVariables;
    } 

    public void SavetoAsset(){
        SaveAsset.SaveLV = Character.GetInstance().PlayerLv;
        SaveAsset.SaveExp = Character.GetInstance().PlayerExp;
        SaveAsset.SaveMoney = Character.GetInstance().Money;
        SaveAsset.SaveQuestOwn = PlayerOwnQuest.GetInstance().QuestOwn;
        SaveAsset.SaveQTrack = PlayerOwnQuest.GetInstance().QuestIDTracking;
        SaveAsset.SaveCurrentAmount = PlayerOwnQuest.GetInstance().CurrentAmount;
        SaveAsset.SaveChestSolved = Character.GetInstance().ChestSolved;
        SaveAsset.SaveChestUnlocked = Character.GetInstance().ChestUnlocked;
        SaveAsset.SaveKillcount = Character.GetInstance().Killcount;
        SaveAsset.SaveDeathC = Character.GetInstance().DeathC;
        SaveAsset.SaveMaxDMG = Character.GetInstance().MaxDMG;
        SaveAsset.SaveCraftEquip = Character.GetInstance().CraftEquip;
        //SaveAsset.SaveDialogueVariables = DialogueManager.GetInstance().dialogueVariables;
        //SaveAsset.SaveCalled++;
        Debug.Log("Save!");
    }

    public void LoadAssetToGame(){
        Character.GetInstance().PlayerLv = SaveAsset.SaveLV;
        Character.GetInstance().PlayerExp = SaveAsset.SaveExp;
        Character.GetInstance().Money = SaveAsset.SaveMoney;
        PlayerOwnQuest.GetInstance().QuestOwn = SaveAsset.SaveQuestOwn;
        PlayerOwnQuest.GetInstance().QuestIDTracking = SaveAsset.SaveQTrack;
        PlayerOwnQuest.GetInstance().CurrentAmount = SaveAsset.SaveCurrentAmount;
        Character.GetInstance().ChestSolved = SaveAsset.SaveChestSolved;
        Character.GetInstance().ChestUnlocked = SaveAsset.SaveChestUnlocked;
        Character.GetInstance().Killcount = SaveAsset.SaveKillcount;
        Character.GetInstance().DeathC = SaveAsset.SaveDeathC;
        Character.GetInstance().MaxDMG = SaveAsset.SaveMaxDMG;
        Character.GetInstance().CraftEquip = SaveAsset.SaveCraftEquip;
        DialogueManager.GetInstance().dialogueVariables = SaveAsset.SaveDialogueVariables;
        Debug.Log("Load!");
    }

    
    private void Awake(){
        if(saveManager==null){
            DontDestroyOnLoad(gameObject);
            saveManager = this;
        }
        if(saveManager!=this){
            Destroy(gameObject);
        }
        
    }

    public static SaveManager GetInstance(){
        return saveManager;
    }

    private void Start(){
        Debug.Log("SceneLoaded");
        int y = SceneManager.GetActiveScene().buildIndex;
        if(y!=10){
            //LoadAssetToGame();
        }
    }

    private void Update(){
        //SavetoAsset();
        //SaveGameData();
    }

    private void OnDestroy(){
        int y = SceneManager.GetActiveScene().buildIndex;
        if(y!=10){
            //SaveGameData();
            //SavetoAsset();
        }
    }
}

