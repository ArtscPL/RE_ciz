using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Decress : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        MoveData.amountShop -= 1;
        if (MoveData.amountShop <= 1) MoveData.amountShop = 1;
    }
}
