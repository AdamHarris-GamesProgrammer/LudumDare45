using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinePlacement : MonoBehaviour
{
    public static int remainingOreDeposits = 10;
    bool hasPlaced = false;
    public GameObject minePrefab;

    void Start()
    {
        Place();
    }

    void Place()
    {

        if (remainingOreDeposits > 1 && !hasPlaced)
        {
            foreach (Transform oreDeposit in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject mineInstance = Instantiate(minePrefab);
                    mineInstance.transform.position = oreDeposit.transform.position;
                    mineInstance.transform.rotation = oreDeposit.transform.rotation;

                    Destroy(oreDeposit.gameObject);
                    Debug.Log("Destroyed:" + oreDeposit.name);

                }

            }
        }
        hasPlaced = false;
    }
}
