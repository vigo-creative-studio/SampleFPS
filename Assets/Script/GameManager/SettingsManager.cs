//This script is responsible for mock settings manager


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    [SerializeField]
    [Range(0, 5f)]
    private float speed;

    [SerializeField]
    private iTween.EaseType easeType;
    /// <summary>
    /// Set inital panel state
    /// </summary>
    void SetPanelActive()
    {
        GameManager.instance._settingsManager.transform.GetChild(0).localPosition = new Vector3(
             1000f, GameManager.instance._settingsManager.transform.GetChild(0).localPosition.y,
            GameManager.instance._settingsManager.transform.GetChild(0).localPosition.z);


        iTween.MoveTo(GameManager.instance._settingsManager.transform.GetChild(0).gameObject, iTween.Hash("position", new Vector3(
           0f,
            GameManager.instance._settingsManager.transform.GetChild(0).localPosition.y,
            GameManager.instance._settingsManager.transform.GetChild(0).localPosition.z), "isLocal", true, "easetype", easeType, "time", speed));
    }



    bool panelStatus = false;
    /// <summary>
    /// Settings Panel enable and dissable actions
    /// </summary>
    public void SettingsPanelAction()
    {
        switch (panelStatus)
        {
            case true:
                panelStatus = false;
                transform.GetComponent<UnityEngine.UI.Image>().enabled = false;
                GameManager.instance._settingsManager.transform.GetChild(0).gameObject.SetActive(false); ;
                break;
            case false:
                SetPanelActive();
                panelStatus = true;
                transform.GetComponent<UnityEngine.UI.Image>().enabled = true;
                GameManager.instance._settingsManager.transform.GetChild(0).gameObject.SetActive(true);
                break;
        }
    }
    /// <summary>
    /// Exit Button Action
    /// </summary>
    public void LoadHome()
    {
        SceneManager.LoadScene(CommonUtilitiesManager.instance._menuSceneName);
    }
}
