using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    private EnemyStat enemy;
    public TurnUse turn;
    public TMP_Text[] showText;
    public Text[] EndText;
    void Start()
    {
        enemy = MoveData.enemyPrefabs.GetComponent<EnemyStat>();
        /*showText[0].text = "+" + enemy.MoneyDrop.ToString();
        showText[1].text = "+" + enemy.expDrop.ToString();
        showText[2].text = turn.turn.ToString();
        showText[3].text = enemy.itemDrop[0].ItemName;
        showText[4].text = enemy.itemDrop[1].ItemName;*/
        Show_Result();
    }

    public void Show_Result(){
        EndText[0].text = "+" + enemy.MoneyDrop.ToString();
        EndText[1].text = "+" + enemy.expDrop.ToString();
        EndText[2].text = turn.turn.ToString();
        EndText[3].text = enemy.itemDrop[0].ItemName+"x1";
        EndText[4].text = enemy.itemDrop[1].ItemName+"x1";
    }
}
