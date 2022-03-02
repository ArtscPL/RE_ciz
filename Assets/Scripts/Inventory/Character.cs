using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kryz.CharacterStats;

public class Character : MonoBehaviour
{
    public CharacterStat Health;
    public CharacterStat Defense;
    public CharacterStat Evasion;
    public CharacterStat Ressistant;
    [SerializeField] Inventory inventory;
    [SerializeField] EquipmentPanal equipmentPanal;
    [SerializeField] StatPanal statPanal;
    private void Awake()
    {
        statPanal.SetStats(Health, Defense, Evasion, Ressistant);
        statPanal.UpdateStatValues();

        inventory.OnItemRightClickedEvent += EquipFromInventory;
        equipmentPanal.OnItemRightClickedEvent += UnequipFromEquipPanal;
    }
    private void EquipFromInventory(Item item)
    {
        if (item is EquipItem)
        {
            Equip((EquipItem)item);
        }
    }

    private void UnequipFromEquipPanal(Item item)
    {
        if (item is EquipItem)
        {
            Unequip((EquipItem)item);
        }
    }
    public void Equip(EquipItem item)
    {
        if (inventory.RemoveItem(item))
        {
            EquipItem previousItem;
            if (equipmentPanal.AddItem(item, out previousItem))
            {
                if (previousItem != null)
                   {
                        inventory.AddItem(previousItem);
                        previousItem.Unequip(this);
                        statPanal.UpdateStatValues();
                   }
                item.Equip(this);
                statPanal.UpdateStatValues();
            }
            else
            {
                inventory.AddItem(item);
            }
        }
    }
    public void Unequip(EquipItem item)
    {
        item.Unequip(this);
        statPanal.UpdateStatValues();
        if (!inventory.IsFull() && equipmentPanal.RemoveItem(item))
        {
            inventory.AddItem(item);
        }
    }
}
