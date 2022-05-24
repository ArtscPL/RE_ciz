using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public struct ItemAmount
{
	public Item Item;
	[Range(1, 999)]
	public int Amount;
}

[CreateAssetMenu]
public class CraftingRecipe : ScriptableObject
{
	public List<ItemAmount> Materials;
	public List<ItemAmount> Results;
	public int Rate;

	public bool CanCraft(IItemContainer itemContainer)
	{
		return HasMaterials(itemContainer) && HasSpace(itemContainer);
	}

	private bool HasMaterials(IItemContainer itemContainer)
	{
		foreach (ItemAmount itemAmount in Materials)
		{
			if (itemContainer.ItemCount(itemAmount.Item.ID) < itemAmount.Amount)
			{
				Debug.LogWarning("You don't have the required materials.");
				return false;
			}
		}
		return true;
	}

	private bool HasSpace(IItemContainer itemContainer)
	{
		foreach (ItemAmount itemAmount in Results)
		{
			if (!itemContainer.CanAddItem(itemAmount.Item, itemAmount.Amount))
			{
				Debug.LogWarning("Your inventory is full.");
				return false;
			}
		}
		return true;
	}

	public void Craft(IItemContainer itemContainer)
	{
		int i = Random.Range(0,101);
		if (CanCraft(itemContainer) && (i <= MoveData.rate))
		{
			RemoveMaterials(itemContainer);
			AddResults(itemContainer);
		}
		else if (CanCraft(itemContainer))
		{
			RemoveMaterials(itemContainer);
			Debug.Log("Fail");
		}
		else Debug.Log("No Mat");
	}
	public void Show()
	{
		MoveData.craftData = new List<Item>();
		MoveData.craftSize = new List<int>();
		
		foreach (ItemAmount itemAmount in Materials)
		{
			MoveData.craftData.Add(itemAmount.Item);
			MoveData.craftSize.Add(itemAmount.Amount);
		}
		foreach (ItemAmount itemAmount in Results)
		{
			MoveData.craftData.Add(itemAmount.Item);
			MoveData.craftSize.Add(itemAmount.Amount);
		}
		MoveData.rate = Rate;
	}

	private void RemoveMaterials(IItemContainer itemContainer)
	{
		foreach (ItemAmount itemAmount in Materials)
		{
			for (int i = 0; i < itemAmount.Amount; i++)
			{
				Item oldItem = itemContainer.RemoveItem(itemAmount.Item.ID);
				oldItem.Destroy();
			}
		}
	}

	private void AddResults(IItemContainer itemContainer)
	{
		foreach (ItemAmount itemAmount in Results)
		{
			for (int i = 0; i < itemAmount.Amount; i++)
			{
				itemContainer.AddItem(itemAmount.Item.GetCopy());
			}
		}
	}
}
