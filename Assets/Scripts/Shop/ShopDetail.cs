using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopDetail : MonoBehaviour
{
    public Text[] textDetailShop;
    
    void Update()
    {
        if (MoveData.shopData != null)
        {
            textDetailShop[0].text = MoveData.shopData.ItemName;
            textDetailShop[1].text = MoveData.shopData.Title;
        }
    }
}
