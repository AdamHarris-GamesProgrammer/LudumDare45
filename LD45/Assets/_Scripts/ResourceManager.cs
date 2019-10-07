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
        moneyText.text = "Money: $ " + playerMoney;
        woodText.text = "Wood: " + playerWood;
        coalText.text = "Coal: " + playerCoal;
        metalText.text = "Metal: " + playerMetal;
        powerText.text = "Power: " + playerPower;
        oilText.text = "Oil: " + playerOil;
    }



}
