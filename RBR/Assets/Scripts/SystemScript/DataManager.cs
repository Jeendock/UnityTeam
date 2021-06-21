using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.IO;

public class DataManager : MonoBehaviour
{
    PlayerData data = new PlayerData();

    [ContextMenu("To Json Data")]
    void SaveDataToJson()
    {
        string jsonData = JsonUtility.ToJson(data, true);
        string path = Path.Combine(Application.dataPath, "/GameData.json");
        File.WriteAllText(path, jsonData);
    }
}

//static GameObject _container;

//static GameObject Container
//{
//    get
//    {
//        return _container;
//    }
//}

//static DataManager _instance;

//public static DataManager Instance
//{
//    get
//    {
//        if (!_instance)
//        {
//            _container = new GameObject();
//            _container.name = "DataManager";
//            _instance = _container.AddComponent(typeof(DataManager)) as DataManager;
//            DontDestroyOnLoad(_container);
//        }
//        return _instance;
//    }
//}