using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{


    public float moneyOutput = 0.40f;
    public float metalOutput = 0.50f;
    public float coalOutput = 0.50f;

    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        ResourceManager.instance.playerMoney += moneyOutput;
        ResourceManager.instance.playerMetal += metalOutput;
        ResourceManager.instance.playerCoal += coalOutput;
    }
}
