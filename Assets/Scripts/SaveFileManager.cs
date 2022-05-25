using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SaveFileManager : MonoBehaviour
{
    public Button Button1;
    public TextMeshProUGUI text1;
    public Button Button2;
    public TextMeshProUGUI text2;
    public Button Button3;
    public TextMeshProUGUI text3;
    // Start is called before the first frame update
    void Awake()
    {
        Button b1 = Button1.GetComponent<Button>();
		b1.onClick.AddListener(ClickSave1);
        Button b2 = Button2.GetComponent<Button>();
		b2.onClick.AddListener(ClickSave2);
        Button b3 = Button3.GetComponent<Button>();
		b3.onClick.AddListener(ClickSave3);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void ClickSave1(){
        SFXmanager.GetInstance().ButtonPressSound();
        string saveName = "slot1";
        SaveManager.GetInstance().SaveToFile(saveName);
        text1.text = "Save 1 - Saved";
    }
    public void ClickSave2(){
        SFXmanager.GetInstance().ButtonPressSound();
        string saveName = "slot2";
        SaveManager.GetInstance().SaveToFile(saveName);
        text2.text = "Save 2 - Saved";
    }
    public void ClickSave3(){
        SFXmanager.GetInstance().ButtonPressSound();
        string saveName = "slot3";
        SaveManager.GetInstance().SaveToFile(saveName);
        text3.text = "Save 3 - Saved";
    }
}
