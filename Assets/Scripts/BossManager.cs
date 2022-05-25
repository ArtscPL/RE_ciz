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
        MoveData.LvPlayer = Character.GetInstance().PlayerLv;
        MoveData.P_Hp = (int)Character.GetInstance().Health.Value;
        MoveData.P_Def = (int)Character.GetInstance().Defense.Value;
        MoveData.P_Eva = (int)Character.GetInstance().Evasion.Value;
        MoveData.P_Res = (int)Character.GetInstance().Resistance.Value;
        MoveData.Scene_index = SceneManager.GetActiveScene().buildIndex;
        SaveManager.GetInstance().SavetoAsset();
        SaveManager.GetInstance().SaveGameData();
        SceneManager.LoadScene(10);
    }

    public void DestroyBossManager(){
        Destroy(gameObject);
    }
}
