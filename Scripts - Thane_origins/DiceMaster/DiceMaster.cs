using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DiceMaster : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TextBox;
    public GameObject NPCName;
    public GameObject NPCText;
    public GameObject FailDiceText;

    private void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            Screen.lockCursor = false;
            Cursor.visible = true;
            ActionText.GetComponent<Text>().text = "Play Dice Game";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                if(GlobalCash.GoldAmount >= 4 && GlobalCash.GoldAmount != 0)
                {
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    SceneManager.LoadScene("DiceGame", LoadSceneMode.Single);
                }
                else
                {
                    FailDiceText.SetActive(true);
                    StartCoroutine("WaitForSec");
                }
                
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator NPC001Active()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<Text>().text = "DiceMaster";
        NPCName.SetActive(true);
        NPCText.GetComponent<Text>().text = "Hello friend, do you want to play a dice game? Press Y for Yes and N for No";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        TextBox.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        FailDiceText.SetActive(false);
    }
}