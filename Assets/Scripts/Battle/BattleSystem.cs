using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public GameObject EnemyPrefabs;
    public Transform EnemyStation;
    void Start()
    {
        EnemyPrefabs = MoveData.enemyPrefabs;
        StartCoroutine(setupBattle());
    }
    IEnumerator setupBattle()
    {
        Instantiate(EnemyPrefabs,EnemyStation);

        yield return new WaitForSeconds(2f);
    }
}
