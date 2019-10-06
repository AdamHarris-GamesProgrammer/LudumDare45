using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject factoryPrefab;

    public void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform spaces in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject factoryInstance = Instantiate(factoryPrefab);
                    factoryInstance.transform.position = spaces.transform.position;
                    factoryInstance.transform.rotation = spaces.transform.rotation;

                    Destroy(spaces.gameObject);
                    Debug.Log("Destroyed:" + spaces.name);

                }

            }
        }
        hasPlaced = false;
    }
}
