using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumbermill : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        ResourceManager.instance.playerMoney += UpgradeMenu.instance.lumbermillMoneyOutput;
        ResourceManager.instance.playerWood += UpgradeMenu.instance.lumbermillWoodOutput;
    }
}
