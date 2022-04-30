using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateState : MonoBehaviour
{
    public Camera camera;
    public TMP_Text[] TextShows;
    public GameObject[] Objects;
    private string[] stateValue;
    private List<int> marbleIndex = new List<int>();
    private List<int> marbleValue = new List<int>();
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        stateValue = new string[TextShows.Length];
        for (int i = 0 ;i < stateValue.Length ;i++)
        {
            stateValue[i] = "";
            TextShows[i].text = stateValue[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetStateMarble(Marble marble)
    {
        int value = marble.number;
        for (int i = 0 ;i < stateValue.Length ;i++)
        {
            if (stateValue[i] == "")
            {
                Objects[i].SetActive(true);
                stateValue[i] = value.ToString();
                TextShows[i].text = stateValue[i];
                marbleIndex.Add(i);
                marbleValue.Add(marble.number);
                break;
            }
        }
    }
}
