using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStationPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject powerStationPrefab;

    void Start()
    {
        Place();
    }

    void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform spaces in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject powerStationInstance = Instantiate(powerStationPrefab);
                    powerStationInstance.transform.position = spaces.transform.position;
                    powerStationInstance.transform.rotation = spaces.transform.rotation;

                    Destroy(spaces.gameObject);
                    Debug.Log("Destroyed:" + spaces.name);

                }

            }
        }
        hasPlaced = false;
    }
}
