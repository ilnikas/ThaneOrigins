﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractorApple : MonoBehaviour
{
    public Camera camera;
    public float ray_Range = 5f;
    public KeyCode interact;

    [Header("Data")]
    public Text data_text_Apple;
    public static int data_amount_Apple = 0;
    
    void Start()
    {
        data_text_Apple.text = data_amount_Apple.ToString();
    }

}


