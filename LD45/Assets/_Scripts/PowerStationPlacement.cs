using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStationPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject powerStationPrefab;

    public float moneyCost = 1000f;
    public float woodCost = 400f;
    public float metalCost = 100f;

    public void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform spaces in transform)
            {

                if (!hasPlaced && ResourceManager.instance.playerMoney >= moneyCost && ResourceManager.instance.playerWood >= woodCost && ResourceManager.instance.playerMetal >= metalCost)
                {
                    hasPlaced = true;
                    GameObject powerStationInstance = Instantiate(powerStationPrefab);
                    powerStationInstance.transform.position = spaces.transform.position;
                    powerStationInstance.transform.rotation = spaces.transform.rotation;

                    GameManager.instance.buildingCounter++;

                    ResourceManager.instance.playerMoney -= moneyCost;
                    ResourceManager.instance.playerMetal -= metalCost;
                    ResourceManager.instance.playerWood -= woodCost;

                    Destroy(spaces.gameObject);


                }

            }
        }
        hasPlaced = false;
    }
}
