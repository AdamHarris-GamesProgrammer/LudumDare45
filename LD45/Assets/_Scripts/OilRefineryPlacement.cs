using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRefineryPlacement : MonoBehaviour
{
    public static int remainingOil = 15;
    bool hasPlaced = false;
    public GameObject refineryPrefab;


    public void Place()
    {

        if (remainingOil > 1 && !hasPlaced)
        {
            foreach (Transform oilDeposit in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject refineryInstance = Instantiate(refineryPrefab);
                    refineryInstance.transform.position = oilDeposit.transform.position;
                    refineryInstance.transform.rotation = oilDeposit.transform.rotation;

                    Destroy(oilDeposit.gameObject);


                }

            }
        }
        hasPlaced = false;
    }
}
