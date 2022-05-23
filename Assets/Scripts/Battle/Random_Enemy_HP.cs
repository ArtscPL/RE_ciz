using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Random_Enemy_HP : MonoBehaviour
{
    public GameObject target;
    public Transform ChatBackGround;
    public Transform Enemy;
    public TMP_Text showText;
    public GameObject Number_HP;
    public StatofPlayer player;
    public TurnUse turn;
    public int HP;
    private EnemyStat enemyStat;
    void Start()
    {
        enemyStat = MoveData.enemyPrefabs.GetComponent<EnemyStat>();
        Number_HP.SetActive(true);
        HP = Random_Number_Enemy_HP(enemyStat.minhp,enemyStat.maxhp);
    }

    void Update()
    {
        if (HP != 0)
        {
            showText.text = HP.ToString();
            Vector3 Pos = Camera.main.WorldToScreenPoint(Enemy.position);
            Pos.y += 175;
            ChatBackGround.position = Pos;
        }
        else
        {
            Number_HP.SetActive(false);
        }
    }
    
    public int Random_Number_Enemy_HP(int min,int max){
       int Enemy_HP = Random.Range(min,max+1);
       return Enemy_HP;
    }

    public void Attack()
    {
        int How = Random_Number_Enemy_HP(0,100);
        if (How > MoveData.P_Eva)
        {
            player.currenthp -= (enemyStat.damage - MoveData.P_Def);
            int hp = player.currenthp;
            bool isDead = player.setHP(hp);
            Debug.Log(hp);
            if (isDead == true)
            {
                target.gameObject.SetActive(true);
                SaveManager.GetInstance().SaveDeathC++;
                Debug.Log("Player is Dead");
            }
        }
        else
        {
            Debug.Log("Evasion Success");
        }
        turn.turn += 1;
    }

    public bool DeadorNot(int DamageRecive)
    {
        if (DamageRecive == 0)
        {
            MoveData.itemFromEnemy = new List<Item>();
            for (int i = 0; i < enemyStat.itemDrop.Length; i++)
            {
                int j = Random_Number_Enemy_HP(0,100);
                if (j <= enemyStat.itemDrop[i].Droprate)
                    MoveData.itemFromEnemy.Add(enemyStat.itemDrop[i]);
            }
            MoveData.Youwin = true;
            SaveManager.GetInstance().SaveKillcount++;
            return true;
        }
        else return false;
    }
}
