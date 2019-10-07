using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyscraper : MonoBehaviour
{


    public float powerRequirementSecond = 2.0f;
    public float moneyOutput = 12.0f;

    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        if (ResourceManager.instance.playerPower >= powerRequirementSecond)
        {
            ResourceManager.instance.playerPower -= powerRequirementSecond;
            ResourceManager.instance.playerMoney += moneyOutput;

        }
    }
}
