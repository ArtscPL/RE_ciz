using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public Inventory Inventory;
    public static AddItemToPlayer instance;
    public static AddItemToPlayer GetInstance()
    {
        return instance;
    }
    public List<Item> storage;

    private void Awake(){
        instance = this;
    }
    
    /*private void Update()
    {
        //GetYOURITEM();
        //StoreinStorage();
    }*/

    public void StoreinStorage(){
        if (MoveData.Youwin == true){
            /*int a=0;
            foreach (Item i in MoveData.itemFromEnemy){
                Debug.Log("Player will get "+i.ItemName);
                storage[a] = i;
                a++;
            }*/
            //Character.GetInstance().PlayerExp += MoveData.Exp;
            //Character.GetInstance().Money += MoveData.Money;
            for(int i = 0;i< MoveData.itemFromEnemy.Count;i++){
                Debug.Log(MoveData.itemFromEnemy[i].ItemName);
                storage[i] = MoveData.itemFromEnemy[i];
            }
            MoveData.Youwin = false;
            GetYOURITEM();
        }
    }

    public void GetYOURITEM()
	{
        /*foreach(Item i in storage){
            Debug.Log("Adding "+i.ItemName);
		    Character.GetInstance().Inventory.AddItem(i);
        }*/
        if(storage[0] != null){
            Character.GetInstance().Inventory.AddItem(storage[0]);
            storage[0] = null;
        }
        if(storage[1] != null){
            Character.GetInstance().Inventory.AddItem(storage[1].GetCopy());
            storage[1] = null;
        }
        //this somehow works?
        if(storage[2] != null){
            Character.GetInstance().Inventory.AddItem(storage[2].GetCopy());
            storage[2] = null;
        }
    }
}
