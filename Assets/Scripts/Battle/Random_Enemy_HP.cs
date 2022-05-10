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
    public EnemyStat enemyStat;
    public PlayerStat player;
    public TurnUse turn;
    public int HP;
    void Start()
    {
        enemyStat = MoveData.enemyPrefabs.GetComponent<EnemyStat>();
        Number_HP.SetActive(true);
        HP = Random_Number_Enemy_HP(enemyStat.minhp,enemyStat.maxhp);
    }

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

    public void Attack()
    {
        int How = Random.Range(0,10);
        if (How >= 3)
        {
            player.currenthp -= enemyStat.damage;
            int hp = player.currenthp;
            bool isDead = player.setHP(hp);
            if (isDead == true)
            {
                Debug.Log("Player is Dead");
            }
        }
        else
        {
            Debug.Log("Evasion Success");
        }
        turn.turn += 1;
    }
}
