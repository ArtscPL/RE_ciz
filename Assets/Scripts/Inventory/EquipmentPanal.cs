using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentPanal : MonoBehaviour
{
    [SerializeField] Transform equipmentSlotsParent;
    [SerializeField] EquipSlot[] equipmentSlots;
    public event Action<Item> OnItemRightClickedEvent;

    private void Awake()
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            equipmentSlots[i].OnRightClickEvent += OnItemRightClickedEvent;
        }
    }
    private void OnValidate()
    {
        equipmentSlots = equipmentSlotsParent.GetComponentsInChildren<EquipSlot>(); 
    }
    public bool AddItem(EquipItem item, out EquipItem previousItem)
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentSlots[i].EquipmentType == item.EquipmentType) 
            {
                previousItem = (EquipItem)equipmentSlots[i].Item;
                equipmentSlots[i].Item = item;
                return true;
            }
        }
        previousItem = null;
        return false;
    }
    public bool RemoveItem(EquipItem item)
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentSlots[i].Item == item)
      
            {
                equipmentSlots[i].Item = null;
                return true;
            }
        }
        return false;
    }
}
