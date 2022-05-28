using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SaveFileManager : MonoBehaviour
{
    public GameObject SaveUI;
    public Button Button1;
    public TextMeshProUGUI text1;
    public Button Button2;
    public TextMeshProUGUI text2;
    public Button Button3;
    public TextMeshProUGUI text3;

    public string path1;// = Application.persistentDataPath + "/saves/" + "slot1" + ".rez";
    public string path2;// = Application.persistentDataPath + "/saves/" + "slot2" + ".rez";
    public string path3;// = Application.persistentDataPath + "/saves/" + "slot3" + ".rez";
    // Start is called before the first frame update
    void Awake()
    {
        Button b1 = Button1.GetComponent<Button>();
		b1.onClick.AddListener(ClickSave1);
        Button b2 = Button2.GetComponent<Button>();
		b2.onClick.AddListener(ClickSave2);
        Button b3 = Button3.GetComponent<Button>();
		b3.onClick.AddListener(ClickSave3);
        path1 = Application.persistentDataPath + "/saves/" + "slot1" + ".rez";
        path2 = Application.persistentDataPath + "/saves/" + "slot2" + ".rez";
        path3 = Application.persistentDataPath + "/saves/" + "slot3" + ".rez";
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void Update(){
        if(SaveUI!=null && SaveUI.activeSelf){
            if(File.Exists(path1))
            text1.text = "Save 1 - Existed";
            if(File.Exists(path2))
            text2.text = "Save 2 - Existed";
            if(File.Exists(path3))
            text3.text = "Save 3 - Existed";
        }
    }


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
