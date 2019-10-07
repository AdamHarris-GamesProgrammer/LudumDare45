using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStation : MonoBehaviour
{


    public float coalCostSecond = 0.2f;
    public float oilCostSecond = 0.05f;

    public float powerOutput = 2.0f;

    bool isOperational = false;
    bool useCoal = true;
    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        if(ResourceManager.instance.playerCoal >= coalCostSecond || ResourceManager.instance.playerOil >= oilCostSecond)
        {
            isOperational = true;
        }
        else
        {
            isOperational = false;
        }

        if(ResourceManager.instance.playerCoal > ResourceManager.instance.playerOil)
        {
            useCoal = true;
        }
        else
        {
            useCoal = false;
        }

        if (isOperational)
        {
            ResourceManager.instance.playerPower += powerOutput;
            if (useCoal)
            {
                ResourceManager.instance.playerCoal -= coalCostSecond;
            }
            else
            {
                ResourceManager.instance.playerOil -= oilCostSecond;
            }
        }
    }
}
