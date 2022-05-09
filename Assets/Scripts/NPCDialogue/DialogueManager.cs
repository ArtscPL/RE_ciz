using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Load Globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Text dialogueText;

    [SerializeField] private Text displayNameText;
    [SerializeField] private Animator portraitAnimator;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private Text[] choicesText;

    private Story currentStory;

    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";
    //private const string QUEST_TAG = "qstatus";
    //private bool qstatus = false;
    //false = accept, true = clear

    private DialogueVariables dialogueVariables;

    public GameObject QuestAcceptUI;
    public GameObject QuestClearUI;
    public GameObject ShopUI;
    public GameObject CraftUI;
    //for quest
    //public QuestBase quest;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;

        dialogueVariables = new DialogueVariables(loadGlobalsJSON);
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        //after this is choices dialogue 
        choicesText = new Text[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<Text>();
            index++;
        }

        //for quest
        //QuestBase.InitializeQuest();
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }

        if (currentStory.currentChoices.Count == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            ContinueStory();
        }

    }

    public void EnterDialogueMode(TextAsset inkJSON,QuestBase quest)
    {
        /*if (qstatus)
        {
            QuestManager.instance.setQuestUIonClear(quest);
        }*/

        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        dialogueVariables.StartListening(currentStory);

        //reset tag
        displayNameText.text = "???";
        portraitAnimator.Play("default");

        ContinueStory();
    }
        

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);

        dialogueVariables.StopListening(currentStory);

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

        //Check condition and open window correspond to tag
        EndCheckWindow();
        //Debug.Log("Quest = "+QuestOpen+", Shop = "+ShopOpen+" and Craft = "+CraftOpen);    
    }

    private void EndCheckWindow(){
        bool QuestOpen = ((Ink.Runtime.BoolValue)DialogueManager
            .GetInstance()
            .GetVariableState("questAccepted")).value;
        bool ShopOpen = ((Ink.Runtime.BoolValue)DialogueManager
            .GetInstance()
            .GetVariableState("Cshop")).value;
        bool CraftOpen = ((Ink.Runtime.BoolValue)DialogueManager
            .GetInstance()
            .GetVariableState("Ccraft")).value;
        Debug.Log("Quest = "+QuestOpen+", Shop = "+ShopOpen+" and Craft = "+CraftOpen);
        if(QuestOpen){
            //quest accept pop up and add quest to player
            QuestWindowPopup();
        }
        else if(ShopOpen){
            //Shop window popup
            ShopWindowPopup();
        }
        else if(CraftOpen){
            //Craft window popup
            CraftWindowPopup();
        }
    }

    private void QuestWindowPopup()
    {
        //QuestAcceptUI.SetActive(true);
        QuestManager.GetInstance().FindQuestAvailiable();
        QuestManager.GetInstance().displayAcceptQuestUI(QuestManager.GetInstance().QuestAvailiable);
        DialogueManager.GetInstance().SetVariableState("questAccepted", new Ink.Runtime.BoolValue(false));
    }

    private void ShopWindowPopup(){
        //ShopUI.SetActive(true);
        DialogueManager.GetInstance().SetVariableState("Cshop", new Ink.Runtime.BoolValue(false));
    }

    private void CraftWindowPopup(){
        CraftUI.SetActive(true);
        DialogueManager.GetInstance().SetVariableState("Ccraft", new Ink.Runtime.BoolValue(false));
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            //display choices for that dialogue line
            DisplayChoices();
            // handle tag
            HandleTags(currentStory.currentTags);
        }
        else
        {
            StartCoroutine(ExitDialogueMode());
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag in HandleTag");
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            //handle the tag with switch
            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;
                /*case QUEST_TAG:
                    if (QUEST_TAG == "accept") { qstatus = false; }
                    else if(QUEST_TAG == "clear") {qstatus = true; }
                    break;*/
                default:
                    Debug.LogWarning("Tag came but can't handle");
                    break;
            }

        }
    }
    
    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;
        
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices than support");
        }
        // display all choices
        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // hide all button that have no choices
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null)
        {
            Debug.LogWarning("Ink variable was found to be null: " + variableName);
        }
        return variableValue;
    }

    
    // this method will allow of a variable defined in globals.ink to be set using C# code
    public void SetVariableState(string variableName, Ink.Runtime.Object variableValue) 
    {
        if (dialogueVariables.variables.ContainsKey(variableName)) 
        {
            dialogueVariables.variables.Remove(variableName);
            dialogueVariables.variables.Add(variableName, variableValue);
        }
        else 
        {
            Debug.LogWarning("Tried to update variable that wasn't initialized by globals.ink: " + variableName);
        }
    } 
     

}
