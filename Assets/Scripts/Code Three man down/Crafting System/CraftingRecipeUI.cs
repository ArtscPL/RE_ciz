﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CraftingRecipeUI : MonoBehaviour
{
	[Header("References")]
	[SerializeField] RectTransform arrowParent;
	[SerializeField] BaseItemSlot[] itemSlots;

	[Header("Public Variables")]
	public ItemContainer ItemContainer;

	private CraftingRecipe craftingRecipe;
	public CraftingRecipe CraftingRecipe {
		get { return craftingRecipe; }
		set { SetCraftingRecipe(value); }
	}

	public event Action<BaseItemSlot> OnPointerEnterEvent;
	public event Action<BaseItemSlot> OnPointerExitEvent;

	private void OnValidate()
	{
		itemSlots = GetComponentsInChildren<BaseItemSlot>(includeInactive: true);
	}

	private void Start()
	{
		foreach (BaseItemSlot itemSlot in itemSlots)
		{
			itemSlot.OnPointerEnterEvent += slot => OnPointerEnterEvent(slot);
			itemSlot.OnPointerExitEvent += slot => OnPointerExitEvent(slot);
		}
	}

	public void OnCraftButtonClick()
	{
		if (craftingRecipe != null && ItemContainer != null)
		{
			int i = Random.Range(0, 101);
			if (i <= MoveData.rate)
			{
				craftingRecipe.Craft(ItemContainer);
			}
			else Debug.Log("Fail");
		}
	}
	public void OnShowButtonClick()
	{
		craftingRecipe.Show();
	}

	private void SetCraftingRecipe(CraftingRecipe newCraftingRecipe)
	{
		craftingRecipe = newCraftingRecipe;

		if (craftingRecipe != null)
		{
			int slotIndex = 0;
			slotIndex = SetSlots(craftingRecipe.Materials, slotIndex);
			arrowParent.SetSiblingIndex(slotIndex);
			slotIndex = SetSlots(craftingRecipe.Results, slotIndex);

			for (int i = slotIndex; i < itemSlots.Length; i++)
			{
				itemSlots[i].transform.parent.gameObject.SetActive(false);
			}

			gameObject.SetActive(true);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}

	private int SetSlots(IList<ItemAmount> itemAmountList, int slotIndex)
	{
		for (int i = 0; i < itemAmountList.Count; i++, slotIndex++)
		{
			ItemAmount itemAmount = itemAmountList[i];
			BaseItemSlot itemSlot = itemSlots[slotIndex];

			itemSlot.Item = itemAmount.Item;
			itemSlot.Amount = itemAmount.Amount;
			itemSlot.transform.parent.gameObject.SetActive(true);
		}
		return slotIndex;
	}
}
