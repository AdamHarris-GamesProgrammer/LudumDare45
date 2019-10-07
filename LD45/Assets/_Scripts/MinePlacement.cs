using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinePlacement : MonoBehaviour
{
    public static int remainingOreDeposits = 10;
    bool hasPlaced = false;
    public GameObject minePrefab;

    public float moneyCost = 100.0f;
    public float woodCost = 20f;

    public void Place()
    {

        if (remainingOreDeposits > 1 && !hasPlaced)
        {
            foreach (Transform oreDeposit in transform)
            {

                if (!hasPlaced && ResourceManager.instance.playerMoney >= moneyCost && ResourceManager.instance.playerWood >= woodCost)
                {
                    hasPlaced = true;
                    GameObject mineInstance = Instantiate(minePrefab);
                    mineInstance.transform.position = oreDeposit.transform.position;
                    mineInstance.transform.rotation = oreDeposit.transform.rotation;

                    GameManager.instance.buildingCounter++;

                    ResourceManager.instance.playerMoney -= moneyCost;
                    ResourceManager.instance.playerWood -= woodCost;

                    Destroy(oreDeposit.gameObject);


                }

            }
        }
        hasPlaced = false;
    }
}
