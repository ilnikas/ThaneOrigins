using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionCollect : MonoBehaviour
{
    
    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject ThisPotion;
    public Text data_text_Potion;

    void Update()
    {
        RotateSpeed = 2;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }
    

    void OnTriggerEnter()
    {
        CollectSound.Play();
        InteractorPotion.data_amount_Potion++;
        data_text_Potion.text = InteractorPotion.data_amount_Potion.ToString();
        ThisPotion.SetActive(false);
    }
    
}
