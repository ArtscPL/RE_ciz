using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> UI_Item = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberSlot = 72;
    private void Awake()
    {
        for(int i = 0; i < numberSlot; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            UI_Item.Add(instance.GetComponentInChildren<UIItem>());
        }
    }
    public void UpdateSlot(int slot,Item item)
    {
        UI_Item[slot].UpdateItem(item);
    }
    public void AddNewItem(Item item)
    {
        UpdateSlot(UI_Item.FindIndex(i => i.item == null), item);
    }
    public void RemoveItem(Item item)
    {
        UpdateSlot(UI_Item.FindIndex(i => i.item == item), null);
    }
}
