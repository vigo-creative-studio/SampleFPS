//Responsible for holding common references for game elements

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public static GameManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        
    }

    [Header("Contains Game screen elements")]
    public ProfileManager _profileManagerObj;
    public SettingsManager _settingsManager;
}
