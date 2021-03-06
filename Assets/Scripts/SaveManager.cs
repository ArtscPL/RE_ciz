using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System;

public class SaveManager : MonoBehaviour
{
    public static SaveManager saveManager;
    public DataToFile data;
    public int SaveCalled=0;
    public int GetLoad=0;
    public float SavePositionX;
    public float SavePositionY;
    public float SavePositionZ;  
    public int SaveLV;
    public int SaveExp; 
    public int SaveMoney;
    //quest
    public QuestManager.QuestInfo SaveQuestOwn;
    public int SaveQTrack;
    public int SaveCurrentAmount;
    public List<int> SaveChestSolved = new List<int>();
    public int SaveChestUnlocked;
    public int SaveKillcount=0;
	public int SaveDeathC=0;
	public int SaveMaxDMG;
	public int SaveCraftEquip;
    public DialogueVariables SaveDialogueVariables;
    public int SaveBossFight;
    public float AudioVolume;
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
        SaveBossFight = BossManager.GetInstance().PlayerFightBossIndex;
        SaveCalled++;
        AudioVolume = SFXmanager.GetInstance().Audio.volume;
        
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
        BossManager.GetInstance().PlayerFightBossIndex = SaveBossFight;
        SFXmanager.GetInstance().Audio.volume = AudioVolume;
        //problem with teleporter
        if(MoveData.UseTP==0){
            if(MoveData.MoveCalled!=0)
            Movement2D.GetInstance().GetLocation().transform.position = new Vector3(SavePositionX,SavePositionY,SavePositionZ); 
        }
        else{
            MoveData.UseTP=0;
        }
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
        SaveAsset.SaveDialogueVariables = DialogueManager.GetInstance().dialogueVariables;
        //SaveAsset.SaveCalled++;
        //Debug.Log("Save!");
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
        /*DataToFile loaddata = LoadSave.GetLoadManager().data;
        if(loaddata.SaveLV != 0){
            data = loaddata;
            GetLoad = MoveData.SlotPick;
            try{
                LoadSave.GetLoadManager().getRektLoadkun();
            }
            catch(MissingReferenceException){
                Debug.Log("bye load kun~");
            }
            LoadtoManager(loaddata);
        }*/
    }

    private void Start(){
        try{
        DataToFile loaddata = LoadSave.GetLoadManager().data;
        if(loaddata.SaveLV != 0){
            data = loaddata;
            GetLoad = MoveData.SlotPick;
            try{
                LoadSave.GetLoadManager().getRektLoadkun();
            }
            catch(MissingReferenceException){
                Debug.Log("bye load kun~");
            }
            LoadtoManager(loaddata);
        }
        }
        catch (NullReferenceException){
            Debug.Log("No data to loaded: null ref ex catched");
        }

        if(SaveLV!=0){
            LoadGameData();
            DialogueManager.GetInstance().LoadInk();
            ChestHandle.GetInstance().InitailizedChest();
        }
        if(GetLoad!=0){
            Movement2D.GetInstance().GetLocation().transform.position = new Vector3(data.SavePositionX,data.SavePositionY,data.SavePositionZ); 
        }
    }

    public static SaveManager GetInstance(){
        return saveManager;
    }

    public void SaveToFile(string saveName){
        //Debug.Log("Touch Save to File");
        data.SaveScene = SceneManager.GetActiveScene().name;
        Debug.Log(data.SaveScene+" Scene is saving");
        data.SavePositionX = Movement2D.GetInstance().GetLocation().transform.position.x;
        data.SavePositionY = Movement2D.GetInstance().GetLocation().transform.position.y;
        data.SavePositionZ = Movement2D.GetInstance().GetLocation().transform.position.z;
        data.SaveLV = Character.GetInstance().PlayerLv;
        data.SaveExp = Character.GetInstance().PlayerExp;
        data.SaveMoney = Character.GetInstance().Money;
        data.SaveQuestOwn = PlayerOwnQuest.GetInstance().QuestOwn;
        data.SaveQTrack = PlayerOwnQuest.GetInstance().QuestIDTracking;
        data.SaveCurrentAmount = PlayerOwnQuest.GetInstance().CurrentAmount;
        data.SaveChestSolved = Character.GetInstance().ChestSolved;
        data.SaveChestUnlocked = Character.GetInstance().ChestUnlocked;
        data.SaveKillcount = Character.GetInstance().Killcount;
        data.SaveDeathC = Character.GetInstance().DeathC;
        data.SaveMaxDMG = Character.GetInstance().MaxDMG;
        data.SaveCraftEquip = Character.GetInstance().CraftEquip;
        data.AudioVolume = SFXmanager.GetInstance().Audio.volume;
        //data.SaveDialogueVariables = DialogueManager.GetInstance().dialogueVariables;
        
        
        //string globalStateJson = DialogueManager.GetInstance().dialogueVariables.GetGlobalVariablesStateJson();
        //data.globalVariablesStateJson = globalStateJson;
        DialogueManager.GetInstance().SaveInk();
        data.SaveBossFight = BossManager.GetInstance().PlayerFightBossIndex;
        Debug.Log("Player Lv:"+data.SaveLV+" is saved");
        //BinaryFormatter formatter = GetBinaryFormatter();
        if(!Directory.Exists(Application.persistentDataPath + "/saves")){
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }
        string path = Application.persistentDataPath + "/saves/" + saveName + ".rez";
        string json = JsonUtility.ToJson(data);
        using StreamWriter writer = new StreamWriter(path);
        writer.Write(json);
        //Character.GetInstance();
        Debug.Log(saveName+":File Saved at "+path);
        string path2 = "/saves/" + saveName + "_item";
        string path3 = "/saves/" + saveName + "_equip";
        ItemSaveManager.GetInstance().SaveInventory(Character.GetInstance(),path2);
        ItemSaveManager.GetInstance().SaveEquipment(Character.GetInstance(),path3);
    }


    public void LoadtoManager(DataToFile load){
        SaveLV = load.SaveLV;
        SaveExp = load.SaveExp;
        SaveMoney = load.SaveMoney;
        SaveQuestOwn = load.SaveQuestOwn;
        SaveQTrack = load.SaveQTrack;
        SaveCurrentAmount = load.SaveCurrentAmount;
        SaveChestSolved = load.SaveChestSolved;
        SaveChestUnlocked = load.SaveChestUnlocked;
        SaveKillcount = load.SaveKillcount;
        SaveDeathC = load.SaveDeathC;
        SaveMaxDMG = load.SaveMaxDMG;
        SaveCraftEquip = load.SaveCraftEquip;
        SaveDialogueVariables = load.SaveDialogueVariables;
        SaveBossFight = load.SaveBossFight;
        AudioVolume = load.AudioVolume;
        
        Debug.Log("Load Complete");
    }

    public void DestroySaveManager(){
        Destroy(gameObject);
    }
}

[System.Serializable]
public class DataToFile{
    public string SaveScene;
    public float SavePositionX;
    public float SavePositionY;
    public float SavePositionZ;  
    public int SaveLV;
    public int SaveExp; 
    public int SaveMoney;
    //quest
    public QuestManager.QuestInfo SaveQuestOwn;
    public int SaveQTrack;
    public int SaveCurrentAmount;
    public List<int> SaveChestSolved = new List<int>();
    public int SaveChestUnlocked;
    public int SaveKillcount=0;
	public int SaveDeathC=0;
	public int SaveMaxDMG;
	public int SaveCraftEquip;
    public DialogueVariables SaveDialogueVariables;
    public string globalVariablesStateJson="";
    public int SaveBossFight;
    public float AudioVolume;
}

