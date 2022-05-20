using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    private EnemyStat enemy;
    public TurnUse turn;
    public Text[] EndText;
    int i = 3;
    void Start()
    {
        enemy = MoveData.enemyPrefabs.GetComponent<EnemyStat>();
        Show_Result();
    }

    public void Show_Result(){
        EndText[0].text = "+" + enemy.MoneyDrop.ToString();
        EndText[1].text = "+" + enemy.expDrop.ToString();
        EndText[2].text = turn.turn.ToString();
        foreach (Item item in MoveData.itemFromEnemy)
        {
            EndText[i].gameObject.SetActive(true);
            EndText[i].text = item.ItemName+"x1";
            i++;
        }
    }
}
