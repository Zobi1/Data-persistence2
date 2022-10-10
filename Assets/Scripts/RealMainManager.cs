using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class RealMainManager : MonoBehaviour
{

    public static RealMainManager Instance;
    public string PlayerName;
    public PlayerScore[] HighScores = new PlayerScore[] { new PlayerScore("John Doe", 0), new PlayerScore("John Doe", 0), new PlayerScore("John Doe", 0), new PlayerScore("John Doe", 0), new PlayerScore("John Doe", 0)};
    private string SavePath;

    private void Awake()
    {
        SavePath = Application.persistentDataPath + "/save.json";
        Debug.Log("Path = " + SavePath);


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
        public PlayerScore[] HighScores;
    }
    [System.Serializable]
    public class PlayerScore
    {
        public int score;
        public string name;

        public PlayerScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    public void SaveAll()
{
        SaveData data = new SaveData();

        data.PlayerName = PlayerName;
        data.HighScores = HighScores;

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
            HighScores = data.HighScores;
        }

    }

    public void UpdateScore(PlayerScore newScore)
    {
        if (newScore.score > HighScores[4].score)
        { HighScores[4] = newScore; }
        
        var sorted = HighScores.OrderByDescending(ob => ob.score).ToArray();
        HighScores = sorted;

        SaveAll();



    }


}
