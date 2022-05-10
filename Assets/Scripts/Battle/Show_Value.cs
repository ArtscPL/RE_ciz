using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Show_Value : MonoBehaviour, IPointerClickHandler
{
    private int DamageFormPlayer;
    private int HealthFromEnemy;
    public CalculateState calculateState;
    public Random_Enemy_HP RandomEnemyHp;
    public List<Marble> marble;
    public int DamageResult;
    public int scenesLoad;

    void Start()
    {
        
    }
    void Update()
    {
        HealthFromEnemy = RandomEnemyHp.HP;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < 9 ; i++)
        {
            calculateState.Objects[i].SetActive(false);
        }
        DamageFormPlayer = calculateState.calculator();

        StartCoroutine(TakeDamage(DamageFormPlayer));

        calculateState.SetStateValue();
        for (int j = 0; j < marble.Count; j++)
        {
            marble[j].Reset();
        }
    }

    IEnumerator TakeDamage(int DamageFormPlayer)
    {
        DamageResult = Mathf.Abs(DamageFormPlayer - HealthFromEnemy);
        yield return new WaitForSeconds(2f);
        RandomEnemyHp.HP = DamageResult;
        if (DamageResult == 0)
        {
            calculateState.Objects[9].SetActive(false);
            Debug.Log("Enemy Dead But Have EnemyID is " + RandomEnemyHp.enemyStat.enemyID.ToString());
        }
        else 
        {
            calculateState.Objects[9].SetActive(false);
            RandomEnemyHp.Attack();
        }
    }
}
