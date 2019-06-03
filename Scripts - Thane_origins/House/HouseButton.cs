using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseButton : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject SellImage;
    public GameObject MyDoor;
    public GameObject CongratsMess;
    public GameObject FailBuyHouseText;
    private int HousePrice = 249;
    public static int HouseSaleStatus;

    public void BuyHouse()
    { // Decrease Money

        if (GlobalCash.GoldAmount >= HousePrice)
        {
            SellImage.SetActive(false);
            CongratsMess.SetActive(true);
            MyDoor.transform.position = new Vector3((float)-3.62,(float)1.638,(float)7.634);
            MyDoor.transform.eulerAngles = new Vector3(
            MyDoor.transform.eulerAngles.x,
            MyDoor.transform.eulerAngles.y + 90,
            MyDoor.transform.eulerAngles.z);
            GlobalCash.GoldAmount -= HousePrice;
            HouseSaleStatus = 7;
        }
        else
        {
            SellImage.SetActive(false);
            NoticeCam.SetActive(false);
            ThePlayer.SetActive(true);
            FailBuyHouseText.SetActive(true);
            StartCoroutine("WaitForSec");
        }
        
    }

    public void ConfirmMess() {
        CongratsMess.SetActive(false);
        NoticeCam.SetActive(false);
        ThePlayer.SetActive(true);
    }

    public void Cancel() {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        SellImage.SetActive(false);
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        FailBuyHouseText.SetActive(false);
    }
}
