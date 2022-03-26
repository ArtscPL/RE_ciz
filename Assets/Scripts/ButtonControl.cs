using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public GameObject NormUI;
    public GameObject PauseMenuUI;
    public GameObject QuestUI;
    public GameObject MapUI;
    public GameObject InventoryUI;
    public GameObject HintUI;
    public GameObject CharacterUI;
    public GameObject RePoUI;
    public Transform player;

    public void Reposition(){
        if (RePoUI.active)
        {
            RePoUI.SetActive(false);
        }
        else
        {
            RePoUI.SetActive(true);
            QuestUI.SetActive(false);
            PauseMenuUI.SetActive(false);
            MapUI.SetActive(false);
            InventoryUI.SetActive(false);
            HintUI.SetActive(false);
            CharacterUI.SetActive(false);
        }
    }

    public void ChangePosition(){
        if(SceneManager.GetActiveScene().name == "Test Dialogue"){
            player.position = new Vector3((float)2.36999989,(float)-1.24000001,(float)-13.2817335);
        }
        else if (SceneManager.GetActiveScene().name == "Centriana"){
            player.position = new Vector3((float)20.5200005,(float)0.32100001,(float)-2.46000004);
        }
        else if (SceneManager.GetActiveScene().name == "Slopakia"){
            player.position = new Vector3((float)-17.5599995,(float)0.259000003,(float)-2.8599999);
        }
        else if (SceneManager.GetActiveScene().name == "Foretina"){
            player.position = new Vector3((float)-15.9200001,(float)0.32100001,(float)-3.27999997);
        }
        else if (SceneManager.GetActiveScene().name == "Probocean"){
            player.position = new Vector3((float)-18.2800007,(float)0.32100001,(float)-3.33999991);
        }
        else if (SceneManager.GetActiveScene().name == "Cavectar"){
            player.position = new Vector3((float)18.8400002,(float)0.32100001,(float)-6.63000011);
        }
        else if (SceneManager.GetActiveScene().name == "Magmatos"){
            player.position = new Vector3((float)-16.1499996,(float)0.469999999,(float)-3.86999989);
        }
        else{
            Debug.Log("Error:Can't get a valid scene name according to Game Map");
        }
    }

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
            CharacterUI.SetActive(false);
            RePoUI.SetActive(false);
        }
    }

    public void Profile(){
        if (CharacterUI.active)
        {
            CharacterUI.SetActive(false);
        }
        else
        {
            CharacterUI.SetActive(true);
            QuestUI.SetActive(false);
            PauseMenuUI.SetActive(false);
            MapUI.SetActive(false);
            InventoryUI.SetActive(false);
            HintUI.SetActive(false);
            RePoUI.SetActive(false);
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
            CharacterUI.SetActive(false);
            RePoUI.SetActive(false);
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
            CharacterUI.SetActive(false);
            RePoUI.SetActive(false);
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
            CharacterUI.SetActive(false);
            RePoUI.SetActive(false);
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
            CharacterUI.SetActive(false);
            RePoUI.SetActive(false);
        }
    }
}
