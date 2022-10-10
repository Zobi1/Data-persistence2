using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInput : MonoBehaviour
{
    public TMP_InputField input;
    public void ChangeName()
    {
        
        RealMainManager.Instance.PlayerName = input.text;
        RealMainManager.Instance.SaveAll();
    }
}
