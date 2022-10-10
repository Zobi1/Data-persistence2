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
        tmp.text = "Best\nScore: " + RealMainManager.Instance.HighScore.ToString() + $"\n({RealMainManager.Instance.HighScorer})";
    }
}
