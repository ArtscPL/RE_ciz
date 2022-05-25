using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveData : MonoBehaviour
{
    public static GameObject enemyPrefabs;
    public static int P_Hp;
    public static int P_Def;
    public static int P_Eva;
    public static int P_Res;
    public static int Exp;
    public static int Money;
    public static int LvPlayer;
    public static List<Item> itemFromEnemy;
    public static bool Youwin;
    public static int Scene_index;
    public static int EXPBattle;
    public static int MoneyBattle;
    public static int SlotPick=0;

    [Header("Craft")]
    public static List<Item> craftData;
    public static List<int> craftSize;
    public static int rate = 50;

    [Header("Shop")]
    public static Item shopData;
    public static int moneyItemShop;
    public static int amountShop = 1;
    public static int totalPriceShop;
}
