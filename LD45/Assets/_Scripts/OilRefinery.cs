using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRefinery : MonoBehaviour
{


    public float powerRequirementSecond = 1.0f;

    public float oilOutput = 0.8f;
    public float moneyOutput = 3.40f;


    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        if(ResourceManager.instance.playerPower >= powerRequirementSecond)
        {
            ResourceManager.instance.playerPower -= powerRequirementSecond;
            ResourceManager.instance.playerMoney += moneyOutput;
            ResourceManager.instance.playerOil += oilOutput;
        }

    }
}
