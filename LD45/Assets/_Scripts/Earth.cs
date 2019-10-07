using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{

    private void Update()
    {
    }

    private void OnMouseOver()
    {
        Debug.Log("Mouse over");
        if (Input.GetMouseButtonDown(0))
        {
            ResourceManager.instance.playerMoney += UpgradeMenu.instance.clickMoneyOutput;
        }
    }

}
