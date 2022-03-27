using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerProfile : MonoBehaviour
{
    public int playerLevel;
    public int playerEXP;
    public int playerMaxHP;
    public int playerDef;
    public int playerEva;
    public int playerRes;
    public int questProgress;
    //all quest = 39
    public int questMax;
    public int MonKill;
    //all chest 23
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
    public int Lesson2_2Score;

    public Text LV;
    public Text EXP;
    public Text MHP;
    public Text Def;
    public Text Eva;
    public Text Res;

    public void ProfileUIchanged(){
        LV.text = "เลเวล:"+ playerLevel.ToString();
        EXP.text = "ค่าประสบการณ์:" + playerEXP.ToString();
        MHP.text = "พลังชีวิตสูงสุด:"+ playerMaxHP.ToString();
        Def.text = "พลังป้องกัน:"+ playerDef.ToString();
        Eva.text = "หลบหลีก:"+ playerEva.ToString();
        Res.text = "ต้านทานสถานะ:"+ playerRes.ToString();
    }
}
