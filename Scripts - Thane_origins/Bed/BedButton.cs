using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedButton : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject BedCam;
    public GameObject UISleepMessage;
    public GameObject NotTiredText;

    public void Sleep() 
    { 
        if (HealthMonitor.MaxHealth == HealthMonitor.HealthValue)
        {
            ThePlayer.SetActive(true);
            BedCam.SetActive(false);
            UISleepMessage.SetActive(false);
            NotTiredText.SetActive(true);
        }

        HealthMonitor.HealthValue = HealthMonitor.MaxHealth;
        ThePlayer.SetActive(true);
        BedCam.SetActive(false);
        UISleepMessage.SetActive(false);
    }

    public void Cancel()
    {
        ThePlayer.SetActive(true);
        BedCam.SetActive(false);
        UISleepMessage.SetActive(false);
    }
}
