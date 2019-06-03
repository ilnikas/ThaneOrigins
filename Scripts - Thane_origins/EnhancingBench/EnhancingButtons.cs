using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnhancingButtons : MonoBehaviour
{
    public GameObject UIEnhancePanel;
    public GameObject ThePlayer;
    public GameObject EnhanceCam;
    public GameObject Heart04;
    public GameObject Heart05;
    public Button myButton1;
    public Button myButton2;
    public Button myButton3;
    public Button myButton4;
    public Button myButton5;
    public Button myButton6;
    public Text data_text_Papyrus;
    
    public void Upgrade1() { 
        myButton1.interactable = false;
        InflictDamage.setDamage1();
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Upgrade2() {
        myButton2.interactable = false; 
        InflictDamage.setDamage2();
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Upgrade3() { 
        myButton3.interactable = false;
        Heart04.SetActive(true);
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Upgrade4() { 
        myButton4.interactable = false;
        Heart05.SetActive(true);
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Upgrade5() { 
        myButton5.interactable = false;
        UnityStandardAssets.Characters.FirstPerson.FirstPersonController.setSpeed1();
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Upgrade6() { 
        myButton6.interactable = false;
        UnityStandardAssets.Characters.FirstPerson.FirstPersonController.setSpeed2();
        InteractorPapyrus.data_amount_Papyrus -= 1;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
    }

    public void Done() {
        ThePlayer.SetActive(true);
        EnhanceCam.SetActive(false);
        UIEnhancePanel.SetActive(false);
    }
}
