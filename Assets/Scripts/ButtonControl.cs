using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject NormUI;
    public GameObject PauseMenuUI;
    public GameObject QuestUI;
    public GameObject MapUI;
    public GameObject InventoryUI;
    public GameObject HintUI;

    public void Setting()
    {
            //for setting button to close and open pause tab
        if (PauseMenuUI.active)
        {
            PauseMenuUI.SetActive(false);
        }
        else
        {
            PauseMenuUI.SetActive(true);
            QuestUI.SetActive(false);
            MapUI.SetActive(false);
            InventoryUI.SetActive(false);
            HintUI.SetActive(false);
        }
    }

    public void Quest()
    {
        if (QuestUI.active)
        {
            QuestUI.SetActive(false);
        }
        else
        {
            QuestUI.SetActive(true);
            PauseMenuUI.SetActive(false);
            MapUI.SetActive(false);
            InventoryUI.SetActive(false);
            HintUI.SetActive(false);
        }
    }

    public void Map()
    {
        if (MapUI.active)
        {
            MapUI.SetActive(false);
        }
        else
        {
            MapUI.SetActive(true);
            PauseMenuUI.SetActive(false);
            InventoryUI.SetActive(false);
            HintUI.SetActive(false);
            QuestUI.SetActive(false);
        }
    }

    public void Inventory()
    {
        if (InventoryUI.active)
        {
            InventoryUI.SetActive(false);
        }
        else
        {
            InventoryUI.SetActive(true);
            PauseMenuUI.SetActive(false);
            HintUI.SetActive(false);
            QuestUI.SetActive(false);
            MapUI.SetActive(false);
        }
    }

    public void Hint()
    {
        if (HintUI.active)
        {
            HintUI.SetActive(false);
        }
        else
        {
            HintUI.SetActive(true);
            PauseMenuUI.SetActive(false);
            InventoryUI.SetActive(false);
            QuestUI.SetActive(false);
            MapUI.SetActive(false);
        }
    }
}
