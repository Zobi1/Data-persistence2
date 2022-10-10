using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetHScore : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Best\nScore: " + RealMainManager.Instance.HighScores[0].score.ToString() + "\n(" + RealMainManager.Instance.HighScores[0].name + ")";
    }
}
