using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractorPapyrus : MonoBehaviour
{
    public Camera camera;
    public float ray_Range = 5f;
    public KeyCode interact;

    [Header("Data")]
    public Text data_text_Papyrus;
    public static int data_amount_Papyrus = 0;
    
    void Start()
    {
        data_text_Papyrus.text = data_amount_Papyrus.ToString();
    }

}
