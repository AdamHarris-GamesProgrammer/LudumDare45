using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyscraperPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject skyscraperPrefab;

    public float moneyCost = 10000f;
    public float metalCost = 3000f;

    public void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform space in transform)
            {

                if (!hasPlaced && ResourceManager.instance.playerMoney >= moneyCost && ResourceManager.instance.playerMetal >= metalCost)
                {
                    hasPlaced = true;
                    GameObject skyscraperInstance = Instantiate(skyscraperPrefab);
                    skyscraperInstance.transform.position = space.transform.position;
                    skyscraperInstance.transform.rotation = space.transform.rotation;

                    ResourceManager.instance.playerMoney -= moneyCost;
                    ResourceManager.instance.playerMetal -= metalCost;

                    Destroy(space.gameObject);
                    Debug.Log("Destroyed:" + space.name);

                }

            }
        }
        hasPlaced = false;
    }
}
