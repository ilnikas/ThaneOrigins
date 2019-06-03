using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhancingBench : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIEnhancePanel;
    public GameObject ThePlayer;
    public GameObject EnhanceCam;
    
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        if (TheDistance <= 2.5) {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action")) {
            if (TheDistance <= 2.5) {
                Screen.lockCursor = false;
                Cursor.visible = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                UIEnhancePanel.SetActive(true);
                EnhanceCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
        }
    }

    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
