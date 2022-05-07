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
    public int min_hp;
    public int max_hp;
    public int HP;
    void Start()
    {
        Number_HP.SetActive(true);
        HP = Random_Number_Enemy_HP(min_hp,max_hp);
    }

    // Update is called once per frame
    void Update()
    {
        showText.text = HP.ToString();
        Vector3 Pos = Camera.main.WorldToScreenPoint(Enemy.position);
        Pos.y += 175;
        ChatBackGround.position = Pos;
    }
    
    public int Random_Number_Enemy_HP(int min,int max){
       int Enemy_HP = Random.Range(min,max+1);
       return Enemy_HP;
    }
}
