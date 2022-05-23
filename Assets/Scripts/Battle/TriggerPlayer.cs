using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPlayer : MonoBehaviour
{
    public GameObject thisEnemy;
    public int MoveTo;
    private void OnTriggerEnter(Collider other) 
    {
        MoveData.enemyPrefabs = thisEnemy;
        if (other.CompareTag("Player"))
        {
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            Destroy(gameObject);
            SceneManager.LoadScene(MoveTo);
        }
    }
}
