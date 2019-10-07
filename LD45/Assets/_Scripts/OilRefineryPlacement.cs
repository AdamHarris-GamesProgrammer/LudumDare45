using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRefineryPlacement : MonoBehaviour
{
    public static int remainingOil = 15;
    bool hasPlaced = false;
    public GameObject refineryPrefab;

    public float moneyCost = 2500f;
    public float metalCost = 1000f;

    public void Place()
    {

        if (remainingOil > 1 && !hasPlaced)
        {
            foreach (Transform oilDeposit in transform)
            {

                if (!hasPlaced && ResourceManager.instance.playerMetal >= moneyCost && ResourceManager.instance.playerMetal >= metalCost)
                {
                    hasPlaced = true;
                    GameObject refineryInstance = Instantiate(refineryPrefab);
                    refineryInstance.transform.position = oilDeposit.transform.position;
                    refineryInstance.transform.rotation = oilDeposit.transform.rotation;

                    GameManager.instance.buildingCounter++;

                    ResourceManager.instance.playerMoney -= moneyCost;
                    ResourceManager.instance.playerMetal -= metalCost;

                    Destroy(oilDeposit.gameObject);


                }

            }
        }
        hasPlaced = false;
    }
}
