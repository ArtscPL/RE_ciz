using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Random_Enemy_HP : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ChatBackGround;
    public Transform Enemy;
    public TMP_Text showText;
    public GameObject Number_HP;
    public int HP;
    void Start()
    {
        Number_HP.SetActive(true);
        HP = Random_Number_Enemy_HP(100,500);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = Camera.main.WorldToScreenPoint(Enemy.position);
        Pos.y += 175;
        ChatBackGround.position = Pos;
    }
    
    private int Random_Number_Enemy_HP(int min,int max){
       int Enemy_HP = Random.Range(min,max+1);
       showText.text = Enemy_HP.ToString();
       return Enemy_HP;
    }
}
