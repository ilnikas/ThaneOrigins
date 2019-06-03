using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalExp : MonoBehaviour
{

    public static int CurrentExp;
    public int InternalExp;
    public GameObject EXPDisplay;


    void Update()
    {
        InternalExp = CurrentExp;
        EXPDisplay.GetComponent<Text>().text = "EXP: " + InternalExp;
    }
}
