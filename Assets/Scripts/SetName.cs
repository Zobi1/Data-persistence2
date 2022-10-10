using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetName : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    
    // Start is called before the first frame update
    void Start()
    {

        if (RealMainManager.Instance.PlayerName != null)
        { tmp.text = RealMainManager.Instance.PlayerName; }
        else
        { tmp.text ="SadLoser"; }


    }

}
