using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnPotionClick : MonoBehaviour, IPointerClickHandler
{
    public StatofPlayer statofPlayer;
    public PotionSys potionSys;
    public string whatPotion;
    private int useL = 0;
    private int useM = 0;
    private int useS = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (whatPotion == "L" && MoveData.havepotionL > 0 && useL < MoveData.havepotionL)
        {
            useL += 1;
            statofPlayer.currenthp += 1000;
            if (statofPlayer.currenthp > statofPlayer.maxhp)
                statofPlayer.setHP(statofPlayer.maxhp);
            else statofPlayer.setHP(statofPlayer.currenthp);
            potionSys.potioncalculate(whatPotion,useL);
        }
        else if (whatPotion == "M" && MoveData.havepotionM > 0 && useM < MoveData.havepotionM) 
        {
            useM += 1;
            statofPlayer.currenthp += 300;
            if (statofPlayer.currenthp > statofPlayer.maxhp)
                statofPlayer.setHP(statofPlayer.maxhp);
            else statofPlayer.setHP(statofPlayer.currenthp);
            potionSys.potioncalculate(whatPotion,useM);
        }
        else if (whatPotion == "S" && MoveData.havepotionS > 0 && useS < MoveData.havepotionS)
        {
            useS += 1;
            statofPlayer.currenthp += 100;
            if (statofPlayer.currenthp > statofPlayer.maxhp)
                statofPlayer.setHP(statofPlayer.maxhp);
            else statofPlayer.setHP(statofPlayer.currenthp);
            potionSys.potioncalculate(whatPotion,useS);
        }
        else Debug.Log("No Potion In Inventory");
    }
}
