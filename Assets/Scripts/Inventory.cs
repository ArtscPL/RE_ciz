using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public Item_Misc_Database itemDatabase;
    public UIInventory inventoryUI;
    public GameObject InventoryPanal;
    private void Start()
    {
        InventoryPanal.gameObject.SetActive(false);
        GiveItem(0);
        GiveItem(1);
        GiveItem(0);
        GiveItem(1);
        GiveItem(0);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            InventoryPanal.gameObject.SetActive(!InventoryPanal.gameObject.activeSelf);
        }
    }
    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item:" + itemToAdd.title);
    }
    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item:" + itemToAdd.title);
    }
    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }
    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Removing item" + itemToRemove.title);
        }
    }
}
