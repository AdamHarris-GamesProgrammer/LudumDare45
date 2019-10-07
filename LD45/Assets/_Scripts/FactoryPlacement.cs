using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject factoryPrefab;

    public float moneyCost = 5000f;
    public float metalCost = 1500f;

    public void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform spaces in transform)
            {

                if (!hasPlaced && ResourceManager.instance.playerMoney >= moneyCost && ResourceManager.instance.playerMetal >= metalCost)
                {
                    hasPlaced = true;
                    GameObject factoryInstance = Instantiate(factoryPrefab);
                    factoryInstance.transform.position = spaces.transform.position;
                    factoryInstance.transform.rotation = spaces.transform.rotation;

                    GameManager.instance.buildingCounter++;

                    ResourceManager.instance.playerMoney -= moneyCost;
                    ResourceManager.instance.playerMetal -= metalCost;

                    Destroy(spaces.gameObject);

                }

            }
        }
        hasPlaced = false;
    }
}
