//This script is responsible for loading screen actions


using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenManager : MonoBehaviour
{
    [SerializeField]
    private Image loadingBar;

    [SerializeField]
    [Range(0, 5f)]
    private float speed;

    private void Start()
    {
        loadingBar.fillAmount = 0;
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1f, "onupdatetarget", gameObject, "onupdate", "updateFromValue", "time", speed, "easetype", iTween.EaseType.easeOutExpo));
    }
    public void updateFromValue(float newValue)
    {
        loadingBar.fillAmount = newValue;

        if (newValue >= 1f)
        {
            GameSelectionScreen();
        }
    }
    void GameSelectionScreen()
    {
        SceneManager.LoadScene(CommonUtilitiesManager.instance._gameSceneName);
    }
}
