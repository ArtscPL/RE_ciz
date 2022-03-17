using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Random_Number_Number : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text showText;
    void Start()
    {
        Random_Number_Marble(0,9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int Random_Number_Marble(int min,int max){
        int Number_Marble = Random.Range(min,max+1);
        showText.text = Number_Marble.ToString();
        return Number_Marble;
    }
}
