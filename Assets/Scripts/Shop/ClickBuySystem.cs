using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBuySystem : MonoBehaviour
{
    public Text MoneyUser;
    public Text AmountItem;
    public Text TotalPriceItem;
    private int TotalPrice;
    private int money;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money = Character.GetInstance().Money;
        MoneyUser.text = money.ToString();
        AmountItem.text = MoveData.amountShop.ToString();
        TotalPrice = MoveData.moneyItemShop * MoveData.amountShop;
        TotalPriceItem.text = TotalPrice.ToString();
        MoveData.totalPriceShop = TotalPrice;
    }
    public void ClickBuy()
    {
        Character.GetInstance().AddItemFromShop();
    }
}
