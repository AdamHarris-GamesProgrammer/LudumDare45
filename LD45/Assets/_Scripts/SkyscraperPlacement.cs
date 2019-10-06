using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyscraperPlacement : MonoBehaviour
{
    public static int remainingSpaces = 15;
    bool hasPlaced = false;
    public GameObject skyscraperPrefab;

    void Start()
    {
        Place();
    }

    void Place()
    {

        if (remainingSpaces > 1 && !hasPlaced)
        {
            foreach (Transform space in transform)
            {

                if (!hasPlaced)
                {
                    hasPlaced = true;
                    GameObject skyscraperInstance = Instantiate(skyscraperPrefab);
                    skyscraperInstance.transform.position = space.transform.position;
                    skyscraperInstance.transform.rotation = space.transform.rotation;

                    Destroy(space.gameObject);
                    Debug.Log("Destroyed:" + space.name);

                }

            }
        }
        hasPlaced = false;
    }
}
