using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSellMessage : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UISellMessage;
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject SellBoardSign;
    
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        if (TheDistance <= 3 && HouseButton.HouseSaleStatus != 7) {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        else
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
        }

        if (HouseButton.HouseSaleStatus != 7)
        {
            SellBoardSign.SetActive(true);
        }
        else
        {
            SellBoardSign.SetActive(false);
        }

        if (Input.GetButtonDown("Action")) {
            if (TheDistance <= 3) {
                Screen.lockCursor = false;
                Cursor.visible = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                UISellMessage.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
        }
    }

    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
