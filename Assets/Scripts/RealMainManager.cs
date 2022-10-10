using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RealMainManager : MonoBehaviour
{

    public static RealMainManager Instance;
    public string PlayerName;
    public int HighScore;
    public string HighScorer;
    private string SavePath;

    private void Awake()
    {
        SavePath = Application.persistentDataPath + "/save.json";


        if (Instance != null)
        { Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadAll();

    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int HighScore;
        public string HighScorer;
    }

    public void SaveAll()
{
        SaveData data = new SaveData();

        data.PlayerName = PlayerName;
        data.HighScore = HighScore;
        data.HighScorer = HighScorer;

        string jsonData = JsonUtility.ToJson(data);

        File.WriteAllText(SavePath, jsonData);

    }

    public void LoadAll()
{
        if (File.Exists(SavePath))
        {
            string jsonData = File.ReadAllText(SavePath);
            SaveData data = JsonUtility.FromJson<SaveData>(jsonData);
            PlayerName = data.PlayerName;
            HighScore = data.HighScore;
            HighScorer = data.HighScorer;
        }

    }


}
