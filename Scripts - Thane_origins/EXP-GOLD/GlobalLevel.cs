using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalLevel : MonoBehaviour
{

    public static int CurrentLevel = 1;
    public int InternalLevel;
    public GameObject LevelDisplay;
    public GameObject NewLevelTextBox;
    private bool[] changedLevel = new bool[10];
    public GameObject Heart1, Heart2, Heart3;

    void Start()
    {
        LevelDisplay.GetComponent<Text>().text = "Level: " + CurrentLevel;
    }

    void Update()
    {
        InternalLevel = CurrentLevel;


        for (int i = 1; i < 10; i++) //10 levels maximum
        {
            if (GlobalExp.CurrentExp >= 350 * i & changedLevel[i] == false)
            {
                CurrentLevel = i + 1;
                LevelDisplay.GetComponent<Text>().text = "Level: " + CurrentLevel;
                StartCoroutine(NewLevelMessage());
                GlobalExp.CurrentExp += 20; //reward with experience
                GlobalCash.GoldAmount += 50; //reward with gold
                HealthMonitor.HealthValue = 3;
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                changedLevel[i] = true;
            }
        }
        
     
    }


    IEnumerator NewLevelMessage()
    {
        if (CurrentLevel % 5 == 0)
        {
            NewLevelTextBox.GetComponent<Text>().text = "Congratulations you moved into a new level stage!";
            GlobalExp.CurrentExp += 40; //reward with bonus experience
            GlobalCash.GoldAmount += 100; //reward with bonus gold

        }
        else
        {
            NewLevelTextBox.GetComponent<Text>().text = "Congratulations you have progressed to level " + CurrentLevel;
        }

        NewLevelTextBox.SetActive(true);
        yield return new WaitForSeconds(2);
        NewLevelTextBox.SetActive(false);

    }
}