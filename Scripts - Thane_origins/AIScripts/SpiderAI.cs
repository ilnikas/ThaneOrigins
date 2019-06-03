using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpiderAI : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 10;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;
    public int DealingDamage;
    public GameObject SpiderWarningText;
    public GameObject PlayerPointer1;
    public GameObject PlayerPointer2;

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance <= AllowedRange)
            {
                PlayerPointer1.SetActive(true);
                PlayerPointer2.SetActive(true);
                EnemySpeed = 0.2f;
                SpiderWarningText.SetActive(true);
                StartCoroutine("WaitForSec");
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                PlayerPointer1.SetActive(false);
                PlayerPointer2.SetActive(false);
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("idle");
            }
        }
        if (AttackTrigger == 1)
        {
            if (DealingDamage == 0)
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("attack");
                StartCoroutine(TakingDamage());
            }
        }
    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

    IEnumerator TakingDamage()
    {
        DealingDamage = 2;
        yield return new WaitForSeconds(0.5f);

        if (SpiderEnemy.GlobalSpider !=6 )
        {
            HealthMonitor.HealthValue -= 1;
        }
       
        yield return new WaitForSeconds(0.4f);
        DealingDamage = 0;
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        SpiderWarningText.SetActive(false);
    }
}