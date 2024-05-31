//This Script holds reference for all common variables throughtout the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonUtilitiesManager : MonoBehaviour
{
    public static CommonUtilitiesManager instance = null;
    public static CommonUtilitiesManager Instance
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
        DontDestroyOnLoad(this.gameObject);
    }
    [Header("Menu Panel Reference")]
    public SplashScreenManager _splashScreenManager;
    public LoadingScreenManager _loadingScreenManager;

    [Header("Scene Names")]
    public string _gameSceneName = "Game";
    public string _menuSceneName = "MenuScene";


    [Header("Dummy Player Data")]
    public string playerNameStr;
    public Sprite playerSprite;
    public string emailStr;

    /// <summary>
    /// Reset the inital game state
    /// </summary>
    private void Start()
    {
        if (_splashScreenManager)
        {
            _loadingScreenManager.gameObject.SetActive(false);
            _splashScreenManager.gameObject.SetActive(true);
        }
    }
}
