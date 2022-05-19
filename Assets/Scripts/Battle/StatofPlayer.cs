using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatofPlayer : MonoBehaviour
{
    public int maxhp;
    public int currenthp;
    public int Def;
    public int Eva;
    public int Res;
    public Slider hpslider;
    void Start()
    {
        Setstat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool setHP(int hp)
    {
        hpslider.value = hp;
        if (hp <= 0)
            return true;
        else return false;
    }

    private void Setstat()
    {
        maxhp = MoveData.P_Hp;
        Def = MoveData.P_Def;
        Eva = MoveData.P_Eva;
        Res = MoveData.P_Res;
        currenthp = maxhp;
        hpslider.maxValue = maxhp;
        hpslider.value = currenthp;
    }
}
