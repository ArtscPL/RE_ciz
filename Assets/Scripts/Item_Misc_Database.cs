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
                new Item(0, "Cure Potion", "นํ้ายาวิเศษที่ว่ากันว่าสามารถรักษาโรคได้ทุกโรค", 
                new Dictionary<string, int>
                {
                    {"ลบล้างค่าสถานะผิดปกติทั้งหมด", 0}
                }),
                new Item(1, "HP Potion (Small)", "นํ้ายารักษาระดับตํ่าใช้สมุนไพรทั่วไปเป็นส่วนผสมหลัก", 
                new Dictionary<string, int>
                {
                    {"+HP", 100}
                }),
                new Item(2, "HP Potion (Medium)", "นํ้ายารักษาระดับกลางใช้สมุนไพรระดับสูงเป็นส่วนผสมหลัก", 
                new Dictionary<string, int>
                {
                    {"+HP", 300}
                }),
                new Item(3, "HP Potion (Large)", "นํ้ายารักษาระดับสูงใช้สมุนไพรฤทธิ์รุนแรงที่เสี่ยงต่อการสูญพันธ์ุเป็นส่วนผสมหลัก", 
                new Dictionary<string, int>
                {
                    {"+HP", 1000}
                }),
            };
    }
}
