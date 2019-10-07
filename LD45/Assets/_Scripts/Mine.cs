using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        ResourceManager.instance.playerMoney += UpgradeMenu.instance.mineMoneyOutput;
        ResourceManager.instance.playerMetal += UpgradeMenu.instance.mineMetalOutput;
        ResourceManager.instance.playerCoal += UpgradeMenu.instance.mineCoalOutput;
    }
}
