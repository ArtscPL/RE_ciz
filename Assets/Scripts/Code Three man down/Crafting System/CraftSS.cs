using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftSS : MonoBehaviour
{
    [Header("Text Show Input")]
	public Text NameItemShow;
	public Text[] materialShow;
	public Text detailShow;
	public Text SuccessShow;
    int i = 0;

    void Update()
    {
        if (MoveData.craftData != null)
        {
            int j = MoveData.craftData.Count;
            NameItemShow.text = MoveData.craftData[j-1].ItemName;
            for (i = 0; i < j-1 ; i++)
            {
                materialShow[i].gameObject.SetActive(true);
                materialShow[i].text = MoveData.craftData[i].ItemName + "    x" + MoveData.craftSize[i].ToString();
            }
            detailShow.text = MoveData.craftData[j-1].Title;
            SuccessShow.text = MoveData.rate.ToString() + "%";
        }
    }
}
