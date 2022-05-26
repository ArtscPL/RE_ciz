using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSys : MonoBehaviour
{
    public void potioncalculate(string whatpotion)
    {
        if (whatpotion == "L")
            MoveData.usepotionL += 1;
        else if (whatpotion == "M") MoveData.usepotionM += 1;
        else MoveData.usepotionS += 1;
        Debug.Log(MoveData.usepotionL);
        Debug.Log(MoveData.usepotionM);
        Debug.Log(MoveData.usepotionS);
    }
}
