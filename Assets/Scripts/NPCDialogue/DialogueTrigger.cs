using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Quest Avaliable")]
    [SerializeField] public QuestBase quest;
    public GameObject QuestClearUI;

    private bool playerInRange;
    public static DialogueTrigger instance;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Trigger in the scene");
        }
        instance = this;
    }
    
    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //pop up clear clear UI
                /*if (quest.IsCompleted)
                {
                    QuestManager.instance.setQuestUIonClear(quest);
                }*/
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON,quest);
            }
        }
        else
        {
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

    public static DialogueTrigger GetInstance()
    {
        return instance;
    }
}
