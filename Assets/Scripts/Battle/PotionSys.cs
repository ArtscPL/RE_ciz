using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSys : MonoBehaviour
{
    public void potioncalculate(string whatpotion,int use)
    {
        if (whatpotion == "L")
            MoveData.usepotionL += use;
        else if (whatpotion == "M") MoveData.usepotionM += use;
        else MoveData.usepotionS += use;
        Debug.Log(MoveData.usepotionL);
        Debug.Log(MoveData.usepotionM);
        Debug.Log(MoveData.usepotionS);
    }
}
