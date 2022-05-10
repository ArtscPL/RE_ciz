using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public GameObject PlayerPrefabs;
    public GameObject EnemyPrefabs;
    public Transform PlayerStation;
    public Transform EnemyStation;
    void Start()
    {
        EnemyPrefabs = MoveData.enemyPrefabs;
        StartCoroutine(setupBattle());
    }
    IEnumerator setupBattle()
    {
        Instantiate(PlayerPrefabs,PlayerStation);
        Instantiate(EnemyPrefabs,EnemyStation);

        yield return new WaitForSeconds(2f);
    }
}
