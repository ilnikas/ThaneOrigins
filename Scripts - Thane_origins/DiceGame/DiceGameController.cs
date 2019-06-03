using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class DiceGameController : MonoBehaviour
{
    public GameObject InputMoney;
    public GameObject InfoMessage;
    public GameObject RollButton;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject FailBetText;
    public GameObject FailBetText2;
    public GameObject FailBetText3;
    private int bet;
    private int heroNumber;
    private int masterNumber;


    public void GetBet(string theBet)
    {
        bet = Int32.Parse(theBet);
        if (bet > GlobalCash.GoldAmount)
        {
            FailBetText.SetActive(true);
            StartCoroutine("WaitForSec1");
        }
        else if (bet == 0 || bet <= 3)
        {
            FailBetText3.SetActive(true);
            StartCoroutine("WaitForSec3");
        }
        else
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
            InfoMessage.SetActive(false);
            InputMoney.SetActive(false);
            InfoMessage.GetComponent<Text>().text = "Press Button to Roll Dice";
            InfoMessage.SetActive(true);
            RollButton.SetActive(true);
        }
        
    }

    

    public void PlayGame()
    {
        System.Random rnd = new System.Random();
        StartCoroutine(Printing());
    }

    IEnumerator Printing()
    {
        System.Random rnd = new System.Random();

            InfoMessage.SetActive(false);
            RollButton.SetActive(false);
            heroNumber = rnd.Next(1, 6);
            masterNumber = rnd.Next(1, 6);
            InfoMessage.GetComponent<Text>().text = "Your roll is... ";
            InfoMessage.SetActive(true);
            yield return new WaitForSeconds(3);
            InfoMessage.GetComponent<Text>().text = "Your roll is... " + heroNumber;
            yield return new WaitForSeconds(1);
            InfoMessage.GetComponent<Text>().text = "Your roll is... " + heroNumber + ". DiceMaster's roll is... ";
            yield return new WaitForSeconds(3);
            InfoMessage.GetComponent<Text>().text = "Your roll is... " + heroNumber + ". DiceMaster's roll is... " + masterNumber;
            yield return new WaitForSeconds(2);
            if (masterNumber >= heroNumber)
            {
                InfoMessage.GetComponent<Text>().text = "Unfortunately you lost...Do you want to try again?";
                GlobalCash.GoldAmount -= bet;
            } else
            {
                GlobalCash.GoldAmount += bet*2;
                InfoMessage.GetComponent<Text>().text = "Congratulations you won! Ready to try again?";
            }
            YesButton.SetActive(true);
            NoButton.SetActive(true);

        
    }

    public void YesButtonListen()
    {
        if (GlobalCash.GoldAmount >= 4)
        {
            NoButton.SetActive(false);
            YesButton.SetActive(false);
            InfoMessage.GetComponent<Text>().text = "Welcome to the Dice Game! How much money do you want to bet?";
            InfoMessage.SetActive(true);
            InputMoney.SetActive(true);
        }else
        {
            FailBetText2.SetActive(true);
            StartCoroutine("WaitForSec2");
            SceneManager.LoadScene("area01", LoadSceneMode.Single);
        }
        
    }

    public void NoButtonListen()
    {
        SceneManager.LoadScene("area01", LoadSceneMode.Single);
    }

    IEnumerator WaitForSec1()
    {
        yield return new WaitForSeconds(4);
        FailBetText.SetActive(false);
    }

    IEnumerator WaitForSec2()
    {
        yield return new WaitForSeconds(4);
        FailBetText2.SetActive(false);
    }

    IEnumerator WaitForSec3()
    {
        yield return new WaitForSeconds(4);
        FailBetText3.SetActive(false);
    }

}
