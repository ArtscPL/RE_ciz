using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Marble : MonoBehaviour
{
    public Camera camera;
    public CalculateState calculateState;
    public int number;
    public TMP_Text showText;
    void Start()
    {
        number = Random_Number_Marble(0,9);
    }

    // Update is called once per frame
    void Update()
    {
        showText.text = number.ToString();
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
                if (hit.transform.name == transform.name)
                {
                    calculateState.GetStateMarble(this);
                    SetMarbleActive(false);
                }
            }  
        } 
    }
    public int Random_Number_Marble(int min,int max){
        int Number_Marble = Random.Range(min,max+1);
        return Number_Marble;
    }
    public void SetMarbleActive(bool status)
    {
        gameObject.SetActive(status);
    }
    public void Reset()
    {
        number = Random_Number_Marble(0,9);
        SetMarbleActive(true);
    }
}
