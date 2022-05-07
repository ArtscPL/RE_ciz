using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Show_Value : MonoBehaviour, IPointerClickHandler
{
    private int DamageFormPlayer;
    private int HealthFromEnemy;
    public CalculateState calculateState;
    public Random_Enemy_HP RandomEnemyHp;
    public List<Marble> marble;
    public int DamageResult;

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
        DamageResult = Mathf.Abs(DamageFormPlayer - HealthFromEnemy);
        RandomEnemyHp.HP = DamageResult;
        calculateState.SetStateValue();
        for (int j = 0; j < marble.Count; j++)
        {
            marble[j].Reset();
        }
    }
}
