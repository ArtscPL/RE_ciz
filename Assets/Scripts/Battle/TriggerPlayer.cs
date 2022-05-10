using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPlayer : MonoBehaviour
{
    public GameObject thisEnemy;
    public int scenesLoad;
    private void OnTriggerEnter(Collider other) 
    {
        MoveData.enemyPrefabs = thisEnemy;
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(scenesLoad);
        }
    }
}
