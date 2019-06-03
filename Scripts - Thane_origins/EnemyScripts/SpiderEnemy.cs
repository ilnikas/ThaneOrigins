using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{

    public int EnemyHealth = 10;
    public GameObject TheSpider;
    public int SpiderStatus;
    public int BaseXP = 10;
    public int BaseGold = 50;
    public int CalculateXP;
    public int CalculateGold;
    public SpiderAI SpiderAIScript;
    public static int GlobalSpider;
    public GameObject VictoryDisplay;
    public GameObject PlayerPointer1;
    public GameObject PlayerPointer2;

    void Start()
    {
        SpiderAIScript = GetComponent<SpiderAI>();    
    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            GlobalSpider = SpiderStatus;
            if (SpiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }
        }
    }

    IEnumerator DeathSpider()
    {
        SpiderAIScript.enabled = false;
        SpiderStatus = 6;
        CalculateXP = BaseXP * GlobalLevel.CurrentLevel; //calculate exp points when the enemy dies
        CalculateGold = BaseGold * GlobalLevel.CurrentLevel;
        GlobalExp.CurrentExp += CalculateXP;
        GlobalCash.GoldAmount += CalculateGold;
        yield return new WaitForSeconds(0.5f);
        VictoryDisplay.SetActive(true);
        TheSpider.GetComponent<Animation>().Play("die");
        PlayerPointer1.SetActive(false);
        PlayerPointer2.SetActive(false);
    }
}
