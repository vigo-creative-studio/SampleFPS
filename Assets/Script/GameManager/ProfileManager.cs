//This script contains mock profile data


using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text name;
    [SerializeField]
    private TMP_Text email;
    [SerializeField]
    private Image playerProfileImg;


    [SerializeField]
    [Range(0, 5f)]
    private float speed;

    [SerializeField]
    private iTween.EaseType easeType;
    private void OnEnable()
    {
        name.text = CommonUtilitiesManager.instance.playerNameStr;
        email.text = CommonUtilitiesManager.instance.emailStr;
        playerProfileImg.sprite = CommonUtilitiesManager.instance.playerSprite;
    }

    void SetPanelActive()
    {
        GameManager.instance._profileManagerObj.transform.GetChild(0).localPosition = new Vector3(
            GameManager.instance._profileManagerObj.transform.GetChild(0).localPosition.x,
            600f,
            GameManager.instance._profileManagerObj.transform.GetChild(0).localPosition.z);


        iTween.MoveTo(GameManager.instance._profileManagerObj.transform.GetChild(0).gameObject, iTween.Hash("position", new Vector3(
            GameManager.instance._profileManagerObj.transform.GetChild(0).localPosition.x,
            0,
            GameManager.instance._profileManagerObj.transform.GetChild(0).localPosition.z), "isLocal", true, "easetype", easeType, "time", speed));
    }



    bool panelStatus = false;
    public void ProfilePanelAction()
    {
        switch (panelStatus)
        {
            case true:
                panelStatus = false;
                transform.GetComponent<UnityEngine.UI.Image>().enabled = false;
                GameManager.instance._profileManagerObj.transform.GetChild(0).gameObject.SetActive(false); ;
                break;
            case false:
                SetPanelActive();
                panelStatus = true;
                transform.GetComponent<UnityEngine.UI.Image>().enabled = true;
                GameManager.instance._profileManagerObj.transform.GetChild(0).gameObject.SetActive(true);
                break;
        }
    }
}
