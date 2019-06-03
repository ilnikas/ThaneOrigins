using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleCollect : MonoBehaviour
{
    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject ThisApple;
    public Text data_text_Apple;
    

    void Update()
    {
        RotateSpeed = 2;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }
    

    void OnTriggerEnter()
    {
        CollectSound.Play();
        InteractorApple.data_amount_Apple++;
        data_text_Apple.text = InteractorApple.data_amount_Apple.ToString();
        ThisApple.SetActive(false);
    }
    
}
