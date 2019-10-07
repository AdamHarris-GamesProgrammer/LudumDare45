using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float clickAmount = 0.3f;

    private void Update()
    {
    }

    private void OnMouseOver()
    {
        Debug.Log("Mouse over");
        if (Input.GetMouseButtonDown(0))
        {
            ResourceManager.instance.playerMoney += clickAmount;
        }
    }

}
