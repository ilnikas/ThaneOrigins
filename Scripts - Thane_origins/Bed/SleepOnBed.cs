using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepOnBed : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UISleepMessage;
    public GameObject ThePlayer;
    public GameObject BedCam;
    
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        if (TheDistance <= 2) {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action")) {
            if (TheDistance <= 2) {
                Screen.lockCursor = false;
                Cursor.visible = true;
                //Cursor.lockState = CursorLockMode.None;
                //Cursor.visible = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                UISleepMessage.SetActive(true);
                BedCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
        }
    }

    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
