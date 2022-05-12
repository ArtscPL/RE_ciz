using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public int maxhp;
    public int currenthp;
    public Slider hpslider;
    void start()
    {
        currenthp = maxhp;
        hpslider.maxValue = maxhp;
        hpslider.value = currenthp;
    }
    public bool setHP(int hp)
    {
        hpslider.value = hp;
        if (hp <= 0)
            return true;
        else return false;
    }
}
