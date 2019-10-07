using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{


    public float powerRequirementSecond = 1.5f;

    public float moneyOutput = 7.0f;

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
