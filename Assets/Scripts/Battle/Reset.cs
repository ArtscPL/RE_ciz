using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Reset : MonoBehaviour, IPointerClickHandler
{
    private Show_Value SV;
    public CalculateState calculateState;
    public List<GameObject> marble;
    void Start()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < 10 ; i++)
        {
            calculateState.Objects[i].SetActive(false);
        }
        calculateState.SetStateValue();
        for (int j = 0; j < marble.Count; j++)
        {
            marble[j].SetActive(true);
        }
        Debug.Log("Reset Complete");
    }
}
