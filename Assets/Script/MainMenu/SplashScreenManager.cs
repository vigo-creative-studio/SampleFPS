//This script is responsible for splash screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreenManager : MonoBehaviour
{
    [SerializeField]
    private float loadTime;
    private void Start()
    {
        Invoke("LoadLoadingScreen", loadTime);
    }
    void LoadLoadingScreen()
    {
        CommonUtilitiesManager.instance._splashScreenManager.gameObject.SetActive(false);
        CommonUtilitiesManager.instance._loadingScreenManager.gameObject.SetActive(true);
    }
}
