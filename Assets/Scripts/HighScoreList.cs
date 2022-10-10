using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreList : MonoBehaviour
{

    public TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "";

        for (int i = 0; i < 5; i++)
        {
            tmp.text += (i + 1).ToString() + "." + RealMainManager.Instance.HighScores[i].name + " - " + RealMainManager.Instance.HighScores[i].score.ToString() + "\n";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
