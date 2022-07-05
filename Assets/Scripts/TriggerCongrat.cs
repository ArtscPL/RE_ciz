using UnityEngine;
using UnityEngine.UI;

public class TriggerCongrat : MonoBehaviour
{
    public GameObject congratUI;
    public Text gradegiven;
    
    public static TriggerCongrat instance;

    public static TriggerCongrat GetInstance()
    {
        return instance;
    }

    public void GetGrade(){
        
        int CScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("CentrianaScore")).value;
        int SScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("SlopakiaScore")).value;
        int FScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("ForetinaScore")).value;
        int PScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("ProboceanScore")).value;
        int CaScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("CavectarScore")).value;
        int chestScore = Character.GetInstance().ChestUnlocked;
        //total max = 21+35 = 56
        //grading for A should be over 50, B around 45-50, C 36-44 and D below= 35
        int total = CScore+SScore+FScore+PScore+CaScore+chestScore;
        congratUI.SetActive(true);
        Debug.Log(total);
        if(total > 49)
        gradegiven.text = "จากการประเมิณผลของเรา\nเกรดของท่านหลังจากเล่นเกมนี้ก็คือ เกรด A (สุดยอด)\n" + "ขอให้ท่านโชคดีกับการทำข้อสอบในชีวิตจริง\n#TeamReCiv";
        else if(total > 39 && total < 50)
        gradegiven.text = "จากการประเมิณผลของเรา\nเกรดของท่านหลังจากเล่นเกมนี้ก็คือ เกรด B (สูง)\n" + "ขอให้ท่านโชคดีกับการทำข้อสอบในชีวิตจริง\n#TeamReCiv";
        else if(total > 29 && total < 40)
        gradegiven.text = "จากการประเมิณผลของเรา\nเกรดของท่านหลังจากเล่นเกมนี้ก็คือ เกรด C (ปานกลาง)\n" + "ขอให้ท่านโชคดีกับการทำข้อสอบในชีวิตจริง\n#TeamReCiv";
        else if(total < 30)
        gradegiven.text = "จากการประเมิณผลของเรา\nเกรดของท่านหลังจากเล่นเกมนี้ก็คือ เกรด D\n" + "ขอให้ท่านโชคดีกับการทำข้อสอบในชีวิตจริง\n#TeamReCiv";
    }

    private void Awake(){
        instance = this;
    }
}
