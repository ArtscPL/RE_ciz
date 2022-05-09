using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum battlestate {START , PLAYERTURN , ENEMYTURN , WIN , LOSE}
public class BattleSystem : MonoBehaviour
{
    public GameObject PlayerPrefabs;
    public GameObject EnemyPrefabs;
    public Transform PlayerStation;
    public Transform EnemyStation;
    public battlestate state;
    void Start()
    {
        state = battlestate.START;
        StartCoroutine(setupBattle());
    }
    IEnumerator setupBattle()
    {
        Instantiate(PlayerPrefabs,PlayerStation);
        Instantiate(EnemyPrefabs,EnemyStation);

        yield return new WaitForSeconds(2f);
    }
}
