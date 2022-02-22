using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Misc_Database : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private void Awake()
    {
        BuildDatabase();
    }
    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }
    void BuildDatabase()
    {
        items = new List<Item>() {
                new Item(0, "Blue Potion", "นี้คือน้ำยาสีฟ้า... อืมน้ำยาสีฟ้า แค่นั้นแหละ", 
                new Dictionary<string, int>
                {
                    {"+MP", 20}
                }),
                new Item(1, "Red Potion", "นี้คือน้ำยาสีแดง... อืมน้ำยาสีแดง แค่นั้นแหละ", 
                new Dictionary<string, int>
                {
                    {"+HP", 20}
                }),
            };
    }
}
