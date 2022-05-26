using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionTotal : MonoBehaviour
{
    public Text[] tttt;
    void Start()
    {
        tttt[0].text = MoveData.havepotionL.ToString();
        tttt[1].text = MoveData.havepotionM.ToString();
        tttt[2].text = MoveData.havepotionS.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
