using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerProfile : MonoBehaviour
{
    /*
    public int questProgress;
    //all quest = 39/604
    public int questMax;
    public int MonKill;
    //all chest 21
    public int ChestMax;
    public int ChestFound;
    public int HighestDMG;
    public int CraftSuccess;
    public int L1scoreMax;
    public int L1_1scoreMax;
    public int L1_2scoreMax;
    public int L2_1scoreMax;
    public int L2_2scoreMax;
    public int Lesson1Score;
    public int Lesson1_1Score;
    public int Lesson1_2Score;
    public int Lesson2_1Score;
    public int Lesson2_2Score;*/

    [Header("Stat UI")]
    public Text LV;
    public Text EXP;
    public Text MHP;
    public Text Def;
    public Text Eva;
    public Text Res;

    [Header("Score UI")]
    public Text questProgress;
    //all quest = 39/604
    public Text MonKill;
    //all chest 21
    public Text ChestFound;
    public Text HighestDMG;
    public Text DeathCount;
    public Text CraftSuccess;
    public Text Lesson1Score;
    public Text Lesson1_1Score;
    public Text Lesson1_2Score;
    public Text Lesson2_1Score;
    public Text Lesson2_2Score;
    public Text ScoreTotal;

    public void ProfileUIchanged(){
        //Debug.Log("Profile called");
        LV.text = "เลเวล:"+ Character.GetInstance().PlayerLv.ToString();
        EXP.text = "ค่าประสบการณ์:" + Character.GetInstance().PlayerExp.ToString();
        MHP.text = "พลังชีวิตสูงสุด:"+ CharacterLv.GetInstance().BaseHP.ToString();
        Def.text = "พลังป้องกัน:"+ CharacterLv.GetInstance().BaseDEF.ToString();
        Eva.text = "หลบหลีก:"+ CharacterLv.GetInstance().BaseEVA.ToString();
        Res.text = "ต้านทานสถานะ:"+ CharacterLv.GetInstance().BaseRES.ToString();
        JustAdjust();
    }

    public void JustAdjust(){
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
        int QuestProgress = PlayerOwnQuest.GetInstance().QuestIDTracking;
        questProgress.text = "ความคืบหน้าภารกิจ(%): " + calculateQuestProgress(QuestProgress) +"%";
        //MonKill
        //ChestFound
        //HighestDMG
        //DeathCount
        //CraftSuccess
        Lesson1Score.text = "หลักการนับ: " + CScore + "/10";
        Lesson1_1Score.text = "การเรียงสับเปลี่ยน: " + SScore + "/5";
        Lesson1_2Score.text = "การจัดหมู่: " + FScore + "/5";
        Lesson2_1Score.text = "ความน่าจะเป็นของเหตุการณ์: " + PScore + "/10";
        Lesson2_2Score.text = "กฏและสมบัติของความน่าจะเป็น: " + CaScore + "/5";
        int total = CScore+SScore+FScore+PScore+CaScore;
        ScoreTotal.text = "รวมทุกบทเรียน: " + total + "/35";
        //Debug.Log("Cen score = "+CScore);
    }

    public float calculateQuestProgress(int QuestID){
        float percent = 0;
        int maxQuest = 39;
        int QuestAt = 0;
        switch(QuestID){
            case 604:
                QuestAt = 39;
                break;
            case 603:
                QuestAt = 38;
                break;
            case 602:
                QuestAt = 37;
                break;
            case 601:
                QuestAt = 36;
                break;
            case 506:
                QuestAt = 35;
                break;
            case 505:
                QuestAt = 34;
                break;
            case 504:
                QuestAt = 33;
                break;
            case 503:
                QuestAt = 32;
                break;
            case 502:
                QuestAt = 31;
                break;
            case 501:
                QuestAt = 30;
                break;
            case 406:
                QuestAt = 29;
                break;
            case 405:
                QuestAt = 28;
                break;
            case 404:
                QuestAt = 27;
                break;
            case 403:
                QuestAt = 26;
                break;
            case 402:
                QuestAt = 25;
                break;
            case 401:
                QuestAt = 24;
                break;
            case 306:
                QuestAt = 23;
                break;
            case 305:
                QuestAt = 22;
                break;
            case 304:
                QuestAt = 21;
                break;
            case 303:
                QuestAt = 20;
                break;
            case 302:
                QuestAt = 19;
                break;
            case 301:
                QuestAt = 18;
                break;
            case 209:
                QuestAt = 17;
                break;
            case 208:
                QuestAt = 16;
                break;
            case 207:
                QuestAt = 15;
                break;
            case 206:
                QuestAt = 14;
                break;
            case 205:
                QuestAt = 13;
                break;
            case 204:
                QuestAt = 12;
                break;
            case 203:
                QuestAt = 11;
                break;
            case 202:
                QuestAt = 10;
                break;
            case 201:
                QuestAt = 9;
                break;
            case 108:
                QuestAt = 8;
                break;
            case 107:
                QuestAt = 7;
                break;
            case 106:
                QuestAt = 6;
                break;
            case 105:
                QuestAt = 5;
                break;
            case 104:
                QuestAt = 4;
                break;
            case 103:
                QuestAt = 3;
                break;
            case 102:
                QuestAt = 2;
                break;
            case 101:
                QuestAt = 1;
                break;
            default:
                QuestAt = 0;
                break;
        }
        percent = (100 * QuestAt)/maxQuest;
        return percent;
    }
}
