using System.Collections.Generic;
using UnityEngine;

public class ItemSaveManager : MonoBehaviour
{
	[SerializeField] ItemDatabase itemDatabase;

	public string InventoryFileName = "Inventory";
	public string EquipmentFileName = "Equipment";
	public string path1_I = "/saves/" + "slot1" + "_item";
    public string path1_E = "/saves/" + "slot1" + "_equip";
    public string path2_I = "/saves/" + "slot2" + "_item";
    public string path2_E = "/saves/" + "slot2" + "_equip";
    public string path3_I = "/saves/" + "slot3" + "_item";
    public string path3_E = "/saves/" + "slot3" + "_equip";
	public static ItemSaveManager instance;

	public static ItemSaveManager GetInstance(){
		return instance;
	}

	private void Awake() {
		instance = this;
	}

	public void LoadInventory(Character character)
	{
		ItemContainerSaveData savedSlots;
		if(MoveData.SlotPick == 0){
			savedSlots = ItemSaveIO.LoadItems(InventoryFileName);
		}
		else if(MoveData.SlotPick == 1){
			savedSlots = ItemSaveIO.LoadItems(path1_I);
		}
		else if(MoveData.SlotPick == 2){
			savedSlots = ItemSaveIO.LoadItems(path1_I);
		}
		else{
			savedSlots = ItemSaveIO.LoadItems(path3_I);
		}
		if (savedSlots == null) return;
		character.Inventory.Clear();

		for (int i = 0; i < savedSlots.SavedSlots.Length; i++)
		{
			ItemSlot itemSlot = character.Inventory.ItemSlots[i];
			ItemSlotSaveData savedSlot = savedSlots.SavedSlots[i];

			if (savedSlot == null)
			{
				itemSlot.Item = null;
				itemSlot.Amount = 0;
			}
			else
			{
				itemSlot.Item = itemDatabase.GetItemCopy(savedSlot.ItemID);
				itemSlot.Amount = savedSlot.Amount;
			}
		}
	}

	public void LoadEquipment(Character character)
	{
		ItemContainerSaveData savedSlots;
		if(MoveData.SlotPick == 0){
			savedSlots = ItemSaveIO.LoadItems(EquipmentFileName);
		}
		else if(MoveData.SlotPick == 1){
			savedSlots = ItemSaveIO.LoadItems(path1_E);
		}
		else if(MoveData.SlotPick == 2){
			savedSlots = ItemSaveIO.LoadItems(path2_E);
		}
		else{
			savedSlots = ItemSaveIO.LoadItems(path3_E);
		}
		if (savedSlots == null) return;

		foreach (ItemSlotSaveData savedSlot in savedSlots.SavedSlots)
		{
			if (savedSlot == null) {
				continue;
			}

			Item item = itemDatabase.GetItemCopy(savedSlot.ItemID);
			character.Inventory.AddItem(item);
			character.Equip((EquippableItem)item);
		}
	}

	public void SaveInventory(Character character,string path)
	{
		if(path == ""){
			SaveItems(character.Inventory.ItemSlots, InventoryFileName);
		}
		else{
			SaveItems(character.Inventory.ItemSlots, path);
		}
	}

	public void SaveEquipment(Character character,string path)
	{
		//SaveItems(character.EquipmentPanel.EquipmentSlots, EquipmentFileName);
		if(path == ""){
			SaveItems(character.EquipmentPanel.EquipmentSlots, EquipmentFileName);
		}
		else{
			SaveItems(character.EquipmentPanel.EquipmentSlots, path);
		}
	}

	private void SaveItems(IList<ItemSlot> itemSlots, string fileName)
	{
		var saveData = new ItemContainerSaveData(itemSlots.Count);

		for (int i = 0; i < saveData.SavedSlots.Length; i++)
		{
			ItemSlot itemSlot = itemSlots[i];

			if (itemSlot.Item == null) {
				saveData.SavedSlots[i] = null;
			} else {
				saveData.SavedSlots[i] = new ItemSlotSaveData(itemSlot.Item.ID, itemSlot.Amount);
			}
		}

		ItemSaveIO.SaveItems(saveData, fileName);
	}
}
