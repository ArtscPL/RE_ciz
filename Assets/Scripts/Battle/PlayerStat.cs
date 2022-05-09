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
    public void setHP(int hp)
    {
        hpslider.value = hp;
    }
}
