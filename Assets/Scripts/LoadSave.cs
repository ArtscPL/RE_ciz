using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadSave : MonoBehaviour
{
    public DataToFile data;
    public static LoadSave LoadManager;
    private void Awake() {
        DontDestroyOnLoad(gameObject);
        LoadManager = this;
    }

    public static LoadSave GetLoadManager(){
        return LoadManager;
    }

    public void LoadSave1()
    {
        Debug.Log("Load Save 1");
        //load game save 1
        string path = Application.persistentDataPath + "/saves/" + "slot1" + ".rez";
        Debug.Log(path);
        LoadFromFile(path);
    }
    public void LoadSave2()
    {
        Debug.Log("Load Save 2");
        //load game save 2
        string path = Application.persistentDataPath + "/saves/" + "slot2" + ".rez";
        Debug.Log(path);
        LoadFromFile(path);
    }
    public void LoadSave3()
    {
        Debug.Log("Load Save 3");
        //load game save 3
        string path = Application.persistentDataPath + "/saves/" + "slot3" + ".rez";
        Debug.Log(path);
        LoadFromFile(path);
    }

    public void LoadFromFile(string path){
        using StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        data = JsonUtility.FromJson<DataToFile>(json);
        //Load Scene and save data
        SceneManager.LoadScene(data.SaveScene);
        Debug.Log("Load Save that have player LV:"+data.SaveLV);
    }

    public void getRektLoadkun(){
        Destroy(gameObject);
    }
}
