using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumbermillPlacement : MonoBehaviour
{
    public static int remainingTrees = 15;
    bool hasPlaced = false;
    public GameObject lumbermillPrefab;

    public void Place()
    {
        
        if(remainingTrees > 1 && !hasPlaced)
        {
            foreach(Transform tree in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject lumbermillInstance = Instantiate(lumbermillPrefab);
                    lumbermillInstance.transform.position = tree.transform.position;
                    lumbermillInstance.transform.rotation = tree.transform.rotation;

                    Destroy(tree.gameObject);
                    
                }

            }
        }
        hasPlaced = false;
    }
}
