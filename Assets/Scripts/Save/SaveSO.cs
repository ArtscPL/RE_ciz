using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SaveObject", menuName = "SaveSystem/SaveObject")]
public class SaveSO : ScriptableObject
{
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
}
