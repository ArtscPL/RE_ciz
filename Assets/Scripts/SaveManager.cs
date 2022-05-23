using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class GameData{
    public int SaveLV;
    public int SaveExp; 
    //quest
    public QuestManager.QuestInfo SaveQuestOwn;
    public int SaveQTrack;
    public int SaveCurrentAmount = 0;
}
