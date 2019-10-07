using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;

    public float playerMoney;
    public float playerWood;
    public float playerMetal;
    public float playerCoal;
    public float playerPower;
    public float playerOil;

    public Text moneyText;
    public Text woodText;
    public Text coalText;
    public Text metalText;
    public Text powerText;
    public Text oilText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);


        playerMoney = 5.0f;
    }

    private void Update()
    {
        moneyText.text = playerMoney.ToString("F2");
        woodText.text = playerWood.ToString("F2");
        coalText.text = playerCoal.ToString("F2");
        metalText.text = playerMetal.ToString("F2");
        powerText.text = playerPower.ToString("F2");
        oilText.text = playerOil.ToString("F2");
    }



}
