using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadSave : MonoBehaviour
{
    public DataToFile data;
    public DataToFile data1;
    public DataToFile data2;
    public DataToFile data3;
    public static LoadSave LoadManager;
    public TextMeshProUGUI save1;
    public TextMeshProUGUI save2;
    public TextMeshProUGUI save3;
    private void Awake() {
        DontDestroyOnLoad(gameObject);
        LoadManager = this;
        string path1 = Application.persistentDataPath + "/saves/" + "slot1" + ".rez";
        string path2 = Application.persistentDataPath + "/saves/" + "slot2" + ".rez";
        string path3 = Application.persistentDataPath + "/saves/" + "slot3" + ".rez";
        data1 = LoadFromFile(path1);
        data2 = LoadFromFile(path2);
        data3 = LoadFromFile(path3);
        save1.text = "Save 1 (LV:"+data1.SaveLV+",Map:"+data1.SaveScene+")";
        save2.text = "Save 2 (LV:"+data2.SaveLV+",Map:"+data2.SaveScene+")";
        save3.text = "Save 3 (LV:"+data3.SaveLV+",Map:"+data3.SaveScene+")";
    }

    public static LoadSave GetLoadManager(){
        return LoadManager;
    }

    public void LoadSave1()
    {
        Debug.Log("Load Save 1");
        //load game save 1
        //string path = Application.persistentDataPath + "/saves/" + "slot1" + ".rez";
        //Debug.Log(path);
        SelectSave(data1);
    }
    public void LoadSave2()
    {
        Debug.Log("Load Save 2");
        //load game save 2
        //string path = Application.persistentDataPath + "/saves/" + "slot2" + ".rez";
        //Debug.Log(path);
        SelectSave(data2);
    }
    public void LoadSave3()
    {
        Debug.Log("Load Save 3");
        //load game save 3
        //string path = Application.persistentDataPath + "/saves/" + "slot3" + ".rez";
        //Debug.Log(path);
        SelectSave(data3);
    }

    public DataToFile LoadFromFile(string path){
        using StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        data = JsonUtility.FromJson<DataToFile>(json);
        return data;
        //Load Scene and save data
        /*SceneManager.LoadScene(data.SaveScene);
        Debug.Log("Load Save that have player LV:"+data.SaveLV);*/
    }

    public void SelectSave(DataToFile savepick){
        data = savepick;
        if(data.SaveLV!=0){
            SceneManager.LoadScene(data.SaveScene);
            Debug.Log("Load Save that have player LV:"+data.SaveLV);
        }
    }

    public void getRektLoadkun(){
        Destroy(gameObject);
    }
}
