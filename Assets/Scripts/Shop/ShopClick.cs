using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopClick : MonoBehaviour, IPointerClickHandler
{
    public Item item_Shop;
    public Text text_Show_Shop;

    void Start()
    {
        text_Show_Shop.text = item_Shop.ItemName;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        MoveData.shopData = item_Shop;
        MoveData.moneyItemShop = item_Shop.Price;
    }
}
