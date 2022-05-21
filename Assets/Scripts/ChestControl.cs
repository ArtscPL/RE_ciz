using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestControl : MonoBehaviour
{
    public static ChestControl instance;
    [SerializeField] public int CID;
    [SerializeField] private GameObject visualCue;
    private bool playerInRange;
    public bool triggerUI { get; set; }

    void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        triggerUI = false;
        if (instance != null)
        {
            //Debug.LogWarning("Found more than one ChestController in the scene");
        }
        instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        if(playerInRange){
            //make cue appear
            visualCue.SetActive(true);
            //Debug.Log(ChestInstance.name);
            //if player touch a key then display UI to solve
            if (Input.GetKeyDown(KeyCode.Space)){
                triggerUI = true;
                PauseDi.instance.Bcon.closeALLUI();
                //sent chestID to manager to manage UI and behavior
                ChestHandle.GetInstance().UIDisplay(CID);
            }
        }
        else{
            //make cue disappear
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
    public static ChestControl GetInstance()
    {
        return instance;
    }

    /*moved from ChestHandle
    public void getAnswer(){
        //answer = inputField.GetComponent<Text>().text;
        answer = inputField.text;
        //Debug.Log(answer);
        CheckAnswer(answer);
    }

    public void CheckAnswer(string ans){
        chestscript = GameObject.Find(ChestInstance.name).GetComponent<ChestControl>();
        if(ans==chestscript.Canswer){
           Debug.Log(ChestInstance.name + ": " + ans + " is Correct~!!");
           //inputField.text = "";
           //answer = "";
           ChestRewardShowUp(); 
        }
        else
        {
            Debug.Log(ChestInstance.name + ": " + ans + " is Wrong~, Try again");
            //inputField.text = "";
            //answer = "";
        }
    }

    public void ChestRewardShowUp(){
        ChestRewardUI.SetActive(true); 
        Reward.text = "ReCoin + " + recoinReward + "\n" + itemReward + " x1";
        //add Reward to player inventory
    }

    private void CloseRewardUI(){
        chestscript = GameObject.Find(ChestInstance.name).GetComponent<ChestControl>();
        Debug.Log(chestscript.ChestInstance.name);
        chestscript.ChestUI.SetActive(false);
        chestscript.ChestInstance.SetActive(false);
        chestscript.triggerUI = false;
    }
    */
}
