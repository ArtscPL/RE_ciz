using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowResult : MonoBehaviour
{
    private EnemyStat enemy;
    public TurnUse turn;
    public TMP_Text[] showText;
    void Start()
    {
        enemy = MoveData.enemyPrefabs.GetComponent<EnemyStat>();
        showText[0].text = "+" + enemy.MoneyDrop.ToString();
        showText[1].text = "+" + enemy.expDrop.ToString();
        showText[2].text = turn.turn.ToString();
        showText[3].text = enemy.itemDrop[0].ItemName;
        showText[4].text = enemy.itemDrop[1].ItemName;
    }
}
