using UnityEngine;
using UnityEngine.UI;
using Kryz.CharacterStats;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
	public static Character instance;
	public float Health00 = 100f;

	public int PlayerLv;
	public int PlayerExp;
	public int Killcount=0;
	public int DeathC=0;
	public int MaxDMG=0;
	public int CraftEquip=0;
	public int ChestUnlocked=0;
	public List<int> ChestSolved = new List<int>();
  


	[Header("Stats")]
	//public int CurrentHP;
	public CharacterStat Health;
	public CharacterStat Defense;
	public CharacterStat Evasion;
	public CharacterStat Resistance;

	[Header("Public")]
	public Inventory Inventory;
	public EquipmentPanel EquipmentPanel;
	public int Money;

	[Header("Serialize Field")]
	[SerializeField] CraftingWindow craftingWindow;
	[SerializeField] StatPanel statPanel;
	[SerializeField] ItemTooltip itemTooltip;
	[SerializeField] Image draggableItem;
	[SerializeField] DropItemArea dropItemArea;
	[SerializeField] QuestionDialog reallyDropItemDialog;
	[SerializeField] ItemSaveManager itemSaveManager;
	[SerializeField] Text ShowMeYourMoney;

	private BaseItemSlot dragItemSlot;
	private void OnValidate()
	{
		if (itemTooltip == null)
			itemTooltip = FindObjectOfType<ItemTooltip>();
	}

	public static Character GetInstance()
    {
        return instance;
    }

	public void ChestUp(){
		ChestUnlocked++;
	}

	public void KillUp(){
		Killcount++;
	}

	public void DeathUp(){
		DeathC++;
	}

	public void ChestUp(int dmg){
		MaxDMG = dmg;
	}

	public void CraftUp(){
		CraftEquip++;
	}

	public void LevelManage(){
		PlayerLv = CharacterLv.GetInstance().levelCalculator(PlayerExp);
		CharacterLv.GetInstance().GetBaseSTAT(PlayerLv);
		Health.BaseValue = CharacterLv.GetInstance().BaseHP;
		Defense.BaseValue = CharacterLv.GetInstance().BaseDEF;
		Evasion.BaseValue = CharacterLv.GetInstance().BaseEVA;
		Resistance.BaseValue = CharacterLv.GetInstance().BaseRES;
		statPanel.SetStats(Health, Defense, Evasion, Resistance);
		statPanel.UpdateStatValues();
	}

	private void Awake()
	{
		if(instance!=null){
            Debug.LogWarning("Found more than one Character in the scene");
        }
        instance = this;
		//Health00 = Health.BaseValue;
		/*
		PlayerLv = CharacterLv.GetInstance().levelCalculator(PlayerExp);
		CharacterLv.GetInstance().GetBaseSTAT(PlayerLv);
		Health.BaseValue = CharacterLv.GetInstance().BaseHP;
		Defense.BaseValue = CharacterLv.GetInstance().BaseDEF;
		Evasion.BaseValue = CharacterLv.GetInstance().BaseEVA;
		Resistance.BaseValue = CharacterLv.GetInstance().BaseRES;
		statPanel.SetStats(Health, Defense, Evasion, Resistance);
		statPanel.UpdateStatValues();*/

		// Setup Events:
		// Right Click
		Inventory.OnRightClickEvent += InventoryRightClick;
		EquipmentPanel.OnRightClickEvent += EquipmentPanelRightClick;
		// Pointer Enter
		Inventory.OnPointerEnterEvent += ShowTooltip;
		EquipmentPanel.OnPointerEnterEvent += ShowTooltip;
		craftingWindow.OnPointerEnterEvent += ShowTooltip;
		// Pointer Exit
		Inventory.OnPointerExitEvent += HideTooltip;
		EquipmentPanel.OnPointerExitEvent += HideTooltip;
		craftingWindow.OnPointerExitEvent += HideTooltip;
		// Begin Drag
		Inventory.OnBeginDragEvent += BeginDrag;
		EquipmentPanel.OnBeginDragEvent += BeginDrag;
		// End Drag
		Inventory.OnEndDragEvent += EndDrag;
		EquipmentPanel.OnEndDragEvent += EndDrag;
		// Drag
		Inventory.OnDragEvent += Drag;
		EquipmentPanel.OnDragEvent += Drag;
		// Drop
		Inventory.OnDropEvent += Drop;
		EquipmentPanel.OnDropEvent += Drop;
		dropItemArea.OnDropEvent += DropItemOutsideUI;
	}

	private void Start()
	{
		LevelManage();
		Health00 = Health.BaseValue;
		if (itemSaveManager != null)
		{
			itemSaveManager.LoadEquipment(this);
			itemSaveManager.LoadInventory(this);
		}
		if(SaveManager.GetInstance()!=null&&SaveManager.GetInstance().SaveCalled>0){
			SaveManager.GetInstance().LoadGameData();
		}
		AddRewardFromBattle();

		//AddItemToPlayer.GetInstance().StoreinStorage();
	}

	private void Update() {
		LevelManage();
		if(ShowMeYourMoney.IsActive()){
			ShowMeYourMoney.text = Money.ToString();
		}
	//	AddItemFromBattle();
	}
	private void AddRewardFromBattle()
	{
		if (MoveData.Youwin)
		{
			Debug.Log("EXP+"+MoveData.EXPBattle);
			Debug.Log("Recoin+"+MoveData.MoneyBattle);
			PlayerExp += MoveData.EXPBattle;
			Money += MoveData.MoneyBattle;
			foreach (Item item in MoveData.itemFromEnemy)
				{
					//Debug.Log(item.ItemName);
					Inventory.AddItem(item.GetCopy());
					//Character.GetInstance().Inventory.AddItem(item);
				}
			//Debug.Log("EnemyID:"+MoveData.enemyPrefabs.GetComponent<EnemyStat>().enemyID);
			PlayerOwnQuest.GetInstance().UpdateCurrentAmount(MoveData.enemyPrefabs.GetComponent<EnemyStat>().enemyID);
			MoveData.Youwin = false;
			MoveData.EXPBattle = 0;
			MoveData.MoneyBattle = 0;
		}
	}
	public void AddItemFromShop()
	{
		Money -= MoveData.totalPriceShop;
		for(int i = 0; i < MoveData.amountShop; i++)
			Inventory.AddItem(MoveData.shopData.GetCopy());
	}
	private void OnDestroy()
	{
		itemSaveManager.SaveEquipment(this);
		itemSaveManager.SaveInventory(this);
	}

	private void InventoryRightClick(BaseItemSlot itemSlot)
	{
		if (itemSlot.Item is EquippableItem)
		{
			Equip((EquippableItem)itemSlot.Item);
		}
		else if (itemSlot.Item is UsableItem)
		{
			UsableItem usableItem = (UsableItem)itemSlot.Item;
			usableItem.Use(this);

			if (usableItem.IsConsumable)
			{
				itemSlot.Amount--;
				usableItem.Destroy();
			}
		}
	}

	private void EquipmentPanelRightClick(BaseItemSlot itemSlot)
	{
		if (itemSlot.Item is EquippableItem)
		{
			Unequip((EquippableItem)itemSlot.Item);
		}
	}

	private void ShowTooltip(BaseItemSlot itemSlot)
	{
		if (itemSlot.Item != null)
		{
			itemTooltip.ShowTooltip(itemSlot.Item);
		}
	}

	private void HideTooltip(BaseItemSlot itemSlot)
	{
		if (itemTooltip.gameObject.activeSelf)
		{
			itemTooltip.HideTooltip();
		}
	}

	private void BeginDrag(BaseItemSlot itemSlot)
	{
		if (itemSlot.Item != null)
		{
			dragItemSlot = itemSlot;
			draggableItem.sprite = itemSlot.Item.Icon;
			draggableItem.transform.position = Input.mousePosition;
			draggableItem.gameObject.SetActive(true);
		}
	}

	private void Drag(BaseItemSlot itemSlot)
	{
		draggableItem.transform.position = Input.mousePosition;
	}

	private void EndDrag(BaseItemSlot itemSlot)
	{
		dragItemSlot = null;
		draggableItem.gameObject.SetActive(false);
	}

	private void Drop(BaseItemSlot dropItemSlot)
	{
		if (dragItemSlot == null) return;

		if (dropItemSlot.CanAddStack(dragItemSlot.Item))
		{
			AddStacks(dropItemSlot);
		}
		else if (dropItemSlot.CanReceiveItem(dragItemSlot.Item) && dragItemSlot.CanReceiveItem(dropItemSlot.Item))
		{
			SwapItems(dropItemSlot);
		}
	}

	private void AddStacks(BaseItemSlot dropItemSlot)
	{
		int numAddableStacks = dropItemSlot.Item.MaximumStacks - dropItemSlot.Amount;
		int stacksToAdd = Mathf.Min(numAddableStacks, dragItemSlot.Amount);

		dropItemSlot.Amount += stacksToAdd;
		dragItemSlot.Amount -= stacksToAdd;
	}

	private void SwapItems(BaseItemSlot dropItemSlot)
	{
		EquippableItem dragEquipItem = dragItemSlot.Item as EquippableItem;
		EquippableItem dropEquipItem = dropItemSlot.Item as EquippableItem;

		if (dropItemSlot is EquipmentSlot)
		{
			if (dragEquipItem != null) dragEquipItem.Equip(this);
			if (dropEquipItem != null) dropEquipItem.Unequip(this);
		}
		if (dragItemSlot is EquipmentSlot)
		{
			if (dragEquipItem != null) dragEquipItem.Unequip(this);
			if (dropEquipItem != null) dropEquipItem.Equip(this);
		}
		statPanel.UpdateStatValues();

		Item draggedItem = dragItemSlot.Item;
		int draggedItemAmount = dragItemSlot.Amount;

		dragItemSlot.Item = dropItemSlot.Item;
		dragItemSlot.Amount = dropItemSlot.Amount;

		dropItemSlot.Item = draggedItem;
		dropItemSlot.Amount = draggedItemAmount;
	}

	private void DropItemOutsideUI()
	{
		if (dragItemSlot == null) return;

		reallyDropItemDialog.Show();
		BaseItemSlot slot = dragItemSlot;
		reallyDropItemDialog.OnYesEvent += () => DestroyItemInSlot(slot);
	}

	private void DestroyItemInSlot(BaseItemSlot itemSlot)
	{
		// If the item is equiped, unequip first
		if (itemSlot is EquipmentSlot)
		{
			EquippableItem equippableItem = (EquippableItem)itemSlot.Item;
			equippableItem.Unequip(this);
		}

		itemSlot.Item.Destroy();
		itemSlot.Item = null;
	}

	public void Equip(EquippableItem item)
	{
		if (Inventory.RemoveItem(item))
		{
			EquippableItem previousItem;
			if (EquipmentPanel.AddItem(item, out previousItem))
			{
				if (previousItem != null)
				{
					Inventory.AddItem(previousItem);
					previousItem.Unequip(this);
					statPanel.UpdateStatValues();
				}
				item.Equip(this);
				statPanel.UpdateStatValues();
			}
			else
			{
				Inventory.AddItem(item);
			}
		}
	}

	public void Unequip(EquippableItem item)
	{
		if (Inventory.CanAddItem(item) && EquipmentPanel.RemoveItem(item))
		{
			item.Unequip(this);
			statPanel.UpdateStatValues();
			Inventory.AddItem(item);
		}
	}

	private ItemContainer openItemContainer;

	private void TransferToItemContainer(BaseItemSlot itemSlot)
	{
		Item item = itemSlot.Item;
		if (item != null && openItemContainer.CanAddItem(item))
		{
			Inventory.RemoveItem(item);
			openItemContainer.AddItem(item);
		}
	}

	private void TransferToInventory(BaseItemSlot itemSlot)
	{
		Item item = itemSlot.Item;
		if (item != null && Inventory.CanAddItem(item))
		{
			openItemContainer.RemoveItem(item);
			Inventory.AddItem(item);
		}
	}

	public void OpenItemContainer(ItemContainer itemContainer)
	{
		openItemContainer = itemContainer;

		Inventory.OnRightClickEvent -= InventoryRightClick;
		Inventory.OnRightClickEvent += TransferToItemContainer;

		itemContainer.OnRightClickEvent += TransferToInventory;

		itemContainer.OnPointerEnterEvent += ShowTooltip;
		itemContainer.OnPointerExitEvent += HideTooltip;
		itemContainer.OnBeginDragEvent += BeginDrag;
		itemContainer.OnEndDragEvent += EndDrag;
		itemContainer.OnDragEvent += Drag;
		itemContainer.OnDropEvent += Drop;
	}

	public void CloseItemContainer(ItemContainer itemContainer)
	{
		openItemContainer = null;

		Inventory.OnRightClickEvent += InventoryRightClick;
		Inventory.OnRightClickEvent -= TransferToItemContainer;

		itemContainer.OnRightClickEvent -= TransferToInventory;

		itemContainer.OnPointerEnterEvent -= ShowTooltip;
		itemContainer.OnPointerExitEvent -= HideTooltip;
		itemContainer.OnBeginDragEvent -= BeginDrag;
		itemContainer.OnEndDragEvent -= EndDrag;
		itemContainer.OnDragEvent -= Drag;
		itemContainer.OnDropEvent -= Drop;
	}

	public void UpdateStatValues()
	{
		statPanel.UpdateStatValues();
	}
}
