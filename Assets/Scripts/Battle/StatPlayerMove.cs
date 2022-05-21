using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatPlayerMove : MonoBehaviour
{
    public Character character;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Enemy"))
        {
            MoveData.LvPlayer = character.PlayerLv;
            MoveData.P_Hp = (int)character.Health.Value;
            MoveData.P_Def = (int)character.Defense.Value;
            MoveData.P_Eva = (int)character.Evasion.Value;
            MoveData.P_Res = (int)character.Resistance.Value;
            MoveData.Scene_index = SceneManager.GetActiveScene().buildIndex;
        }
    }
}
