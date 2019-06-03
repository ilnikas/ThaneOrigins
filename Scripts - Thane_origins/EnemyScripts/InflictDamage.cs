using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour
{

    public static int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 2.7f;

    void Update()
    {
        DamageAmount = GlobalLevel.CurrentLevel * 5; //changing amount according to level
        //DamageAmount = 2 * 5;
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                TargetDistance = hit.distance;
                if (TargetDistance <= AllowedRange)
                {
                    hit.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }

    public static void setDamage1()
    {
        DamageAmount += 2;
    }

    public static void setDamage2()
    {
        DamageAmount += 4;
    }

}