using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeMenu : MonoBehaviour
{
    public static UpgradeMenu instance;

    public float clickMoneyOutput = 0.3f;

    public float lumbermillMoneyOutput = 0.3f;
    public float lumbermillWoodOutput = 0.3f;

    public float mineMoneyOutput = 0.40f;
    public float mineMetalOutput = 0.5f;
    public float mineCoalOutput = 0.5f;

    public float powerStationPowerOutput = 2.0f;

    public float oilRefineryMoneyOutput = 3.40f;
    public float oilRefineryOilOutput = 0.5f;

    public float factoryMoneyOutput = 13.40f;

    public float skyscraperMoneyOutput = 15f;

    public float clickUpgradeCost = 15f;
    public float lumbermillUpgradeCost = 25f;
    public float mineUpgradeCost = 250f;
    public float powerStationUpgradeCost = 1500f;
    public float oilRefineryUpgradeCost = 5000f;
    public float factoryUpgradeCost = 7500f;
    public float skyscraperUpgradeCost = 15000f;

    public float clickUpgradeCostIncrease = 2f;
    public float lumbermillUpgradeCostIncrease = 1.2f;
    public float mineUpgradeCostIncrease = 1.25f;
    public float powerStationUpgradeCostIncrease = 1.3f;
    public float oilRefineryUpgradeCostIncrease = 1.35f;
    public float factoryUpgradeCostIncrease = 1.4f;
    public float skyscraperUpgradeCostIncrease = 1.45f;

    public int maxLevel = 10;
    public int clickLevel = 1;
    public int lumbermillLevel = 1;
    public int mineLevel = 1;
    public int powerStationLevel = 1;
    public int factoryLevel = 1;
    public int oilRefineryLevel = 1;
    public int skyscraperLevel = 1;


    public Text clickText;
    public Text lumbermillText;
    public Text mineText;
    public Text powerStationText;
    public Text oilRefineryText;
    public Text factoryText;
    public Text skyscraperText;
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
    }


    public void LumbermillUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= lumbermillUpgradeCost && lumbermillLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= lumbermillUpgradeCost;
            lumbermillWoodOutput *= 2f;
            lumbermillMoneyOutput *= 2f;
            lumbermillUpgradeCost *= lumbermillUpgradeCostIncrease;
            lumbermillLevel++;
        }
    }

    public void MineUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= mineUpgradeCost && mineLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= mineUpgradeCost;
            mineMoneyOutput *= 2f;
            mineMetalOutput *= 2f;
            mineCoalOutput *= 2f;
            mineUpgradeCost *= mineUpgradeCostIncrease;
            mineLevel++;
        }
    }

    public void PowerStationUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= powerStationUpgradeCost && powerStationLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= powerStationUpgradeCost;
            powerStationPowerOutput *= 2f;


            powerStationUpgradeCost *= powerStationUpgradeCostIncrease;
            powerStationLevel++;
        }
    }

    public void OilRefineryUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= oilRefineryUpgradeCost && oilRefineryLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= oilRefineryUpgradeCost;
            oilRefineryMoneyOutput *= 2f;
            oilRefineryOilOutput *= 2f;
            oilRefineryUpgradeCost *= oilRefineryUpgradeCostIncrease;

            oilRefineryLevel++;
        }
    }

    public void FactoryUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= factoryUpgradeCost && factoryLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= factoryUpgradeCost;
            factoryMoneyOutput *= 2f;
            factoryUpgradeCost *= factoryUpgradeCostIncrease;

            factoryLevel++;
        }
    }

    public void SkyscraperUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= skyscraperUpgradeCost && skyscraperLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= skyscraperUpgradeCost;
            skyscraperMoneyOutput *= 2f;
            skyscraperUpgradeCost *= skyscraperUpgradeCostIncrease;

            skyscraperLevel++;
        }
    }

    public void ClickUpgrade()
    {
        if (ResourceManager.instance.playerMoney >= clickUpgradeCost && clickLevel < maxLevel)
        {
            ResourceManager.instance.playerMoney -= clickUpgradeCost;
            clickMoneyOutput = clickMoneyOutput * 2;
            clickUpgradeCost *= clickUpgradeCostIncrease;
            clickLevel++;
        }
    }

    void Update()
    {
        if(clickLevel != maxLevel)
        {
            clickText.text = "Upgrade Clicking: $" + clickUpgradeCost.ToString("F2");
        }
        else
        {
            clickText.text = "Upgrade Clicking: MAX LEVEL"; 
        }
        
        if(lumbermillLevel != maxLevel)
        {
            lumbermillText.text = "Upgrade Lumbermill: $" + lumbermillUpgradeCost.ToString("F2");
        }
        else
        {
            lumbermillText.text = "Upgrade Lumbermill: MAX LEVEL";
        }

        if(mineLevel != maxLevel)
        {
            mineText.text = "Upgrade Mine: $" + mineUpgradeCost.ToString("F2");
        }
        else
        {
            mineText.text = "Upgrade Mine: MAX LEVEL";
        }
        
        if(powerStationLevel != maxLevel)
        {
            powerStationText.text = "Upgrade Power Station: $" + powerStationUpgradeCost.ToString("F2");
        }
        else
        {
            powerStationText.text = "Upgrade Power Station: MAX LEVEL";
        }

        if(oilRefineryLevel != maxLevel)
        {
            oilRefineryText.text = "Upgrade Oil Refineries: $" + oilRefineryUpgradeCost.ToString("F2");
        }
        else
        {
            oilRefineryText.text = "Upgrade Oil Refinery: MAX LEVEL";
        }

        if (factoryLevel != maxLevel)
        {
            factoryText.text = "Upgrade Factory: $" + factoryUpgradeCost.ToString("F2");
        }
        else
        {
            factoryText.text = "Upgrade Factory: MAX LEVEL";
        }

        if(skyscraperLevel != maxLevel)
        {
            skyscraperText.text = "Upgrade Skyscraper: $" + skyscraperUpgradeCost.ToString("F2");
        }
        else
        {
            skyscraperText.text = "Upgrade Skyscraper: MAX LEVEL";
        }
        
    }
}
