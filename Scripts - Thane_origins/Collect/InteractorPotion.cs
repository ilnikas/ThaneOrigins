using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteractorPotion : MonoBehaviour
{
    public Camera camera;
    public float ray_Range = 5f;
    public KeyCode interact;

    [Header("Data")]
    public Text data_text_Potion;
    public static int data_amount_Potion = 0;
    
    void Start()
    {
        data_text_Potion.text = data_amount_Potion.ToString();
    }

}
