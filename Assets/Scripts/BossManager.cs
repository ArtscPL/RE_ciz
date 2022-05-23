using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossManager : MonoBehaviour
{
    public static BossManager instance;
    public GameObject[] BossList;
    public int PlayerFightBossIndex = 0;

    public static BossManager GetInstance(){
        return instance;
    }

    private void Awake(){
        if(instance == null){
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        if(instance!=this){
            Destroy(gameObject);
        }
    }

    public void TriggerBoss(){
        MoveData.enemyPrefabs = BossList[PlayerFightBossIndex];
        PlayerFightBossIndex++;
        SceneManager.LoadScene(10);
    }
}
