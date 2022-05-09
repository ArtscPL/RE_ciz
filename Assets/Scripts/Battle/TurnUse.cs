using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnUse : MonoBehaviour
{
    public TMP_Text showText;
    public int turn = 1;
    void Start()
    {
        
    }

    void Update()
    {
        showText.text = "Turn " + turn.ToString();
    }
}
