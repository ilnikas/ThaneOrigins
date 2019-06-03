using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollCollect02 : MonoBehaviour
{
    
    public int RotateSpeed;
    public AudioSource CollectSound;
    public Button myButton;
    public GameObject ThisScroll;
    public Text data_text_Papyrus;
    

    void Update()
    {
        RotateSpeed = 2;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }
    

    void OnTriggerEnter()
    {
        CollectSound.Play();
        InteractorPapyrus.data_amount_Papyrus++;
        data_text_Papyrus.text = InteractorPapyrus.data_amount_Papyrus.ToString();
        myButton.interactable = true;
        ThisScroll.SetActive(false);
    }
    
}
