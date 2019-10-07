using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumbermill : MonoBehaviour
{

    public float moneyOutput = 0.30f;
    public float woodOutput = 0.20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generation", 1f, 1f);
    }


    void Generation()
    {
        ResourceManager.instance.playerMoney += moneyOutput;
        ResourceManager.instance.playerWood += woodOutput;
    }
}
