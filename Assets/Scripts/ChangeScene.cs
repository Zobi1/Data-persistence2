using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[DefaultExecutionOrder(1000)]
public class ChangeScene : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene("main");
    }

    public void GoToScores()
    {
        SceneManager.LoadScene("scores");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("start");
    }
}
