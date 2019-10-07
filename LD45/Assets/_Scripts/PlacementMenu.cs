using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlacementMenu : MonoBehaviour
{
    public Toggle lumbermill;
    public Toggle mine;
    public Toggle powerStation;
    public Toggle oilRefinery;
    public Toggle factory;
    public Toggle skyscraper;

    public LumbermillPlacement lp;
    public MinePlacement mp;
    public PowerStationPlacement psp;
    public OilRefineryPlacement orp;
    public SkyscraperPlacement sp;
    public FactoryPlacement fp;

    public GameObject descriptionBox;
    public Text lumbermillText;
    public Text mineText;
    public Text powerStationText;
    public Text oilRefineryText;
    public Text factoryText;
    public Text skyscraperText;


   
    public AudioSource BuySound;

    private void Update()
    {
        lumbermillText.gameObject.SetActive(lumbermill.isOn);
        mineText.gameObject.SetActive(mine.isOn);
        powerStationText.gameObject.SetActive(powerStation.isOn);
        oilRefineryText.gameObject.SetActive(oilRefinery.isOn);
        factoryText.gameObject.SetActive(factory.isOn);
        skyscraperText.gameObject.SetActive(skyscraper.isOn);

        if (lumbermill.isOn)
        {
            descriptionBox.SetActive(true);
            lumbermillText.text = "LUMBERMILL\nCost: $" + lp.moneyCost + "\nIncome: $" + UpgradeMenu.instance.lumbermillMoneyOutput + "\nWood Output: " + UpgradeMenu.instance.lumbermillWoodOutput;

        }
        else if (mine.isOn)
        {
            descriptionBox.SetActive(true);
            mineText.text = "MINE\nCost: $" + mp.moneyCost + "\nWood Cost: " + mp.woodCost + "\nIncome: $" + UpgradeMenu.instance.mineMoneyOutput + "\nMetal Output: " + UpgradeMenu.instance.mineMetalOutput + "\nCoal Output: " + UpgradeMenu.instance.mineCoalOutput;
  
        }
        else if (powerStation.isOn)
        {
            descriptionBox.SetActive(true);
            powerStationText.text = "POWER STATION\nCost: $" + psp.moneyCost + "\nMetal Cost: " + psp.metalCost + "\nWood Cost: " + psp.woodCost + "Power Output: " + UpgradeMenu.instance.powerStationPowerOutput;

        }
        else if (oilRefinery.isOn)
        {
            descriptionBox.SetActive(true);
            oilRefineryText.text = "OIL REFINERY\nCost: $" + orp.moneyCost + "\nMetal Cost: " + orp.metalCost + "\nIncome: $" + UpgradeMenu.instance.oilRefineryMoneyOutput + "\nOil Refinery: " + UpgradeMenu.instance.oilRefineryOilOutput;
           
        }
        else if (factory.isOn)
        {
            descriptionBox.SetActive(true);
            factoryText.text = "FACTORY\nCost: $" + fp.moneyCost + "\nMetal Cost: " + fp.metalCost + "\nIncome: $" + UpgradeMenu.instance.factoryMoneyOutput;
  
        }
        else if (skyscraper.isOn)
        {
            descriptionBox.SetActive(true);
            skyscraperText.text = "SKYSCRAPER\nCost: $" + sp.moneyCost + "\nMetal Cost: " + sp.metalCost + "\nIncome: $" + UpgradeMenu.instance.skyscraperMoneyOutput;
        
        }
    }

    public void PlaceItem()
    {
        if (lumbermill.isOn)
        {
            ////BuySound.Play();
            lp.Place();
        } 
        else if (mine.isOn)
        {
            //BuySound.Play();
            mp.Place();
        }
        else if (powerStation.isOn)
        {
            //BuySound.Play();
            psp.Place();
        }
        else if (oilRefinery.isOn)
        {
            //BuySound.Play();
            orp.Place();
        }
        else if (factory.isOn)
        {
            //BuySound.Play();
            fp.Place();
        }
        else if (skyscraper.isOn)
        {
            //BuySound.Play();
            sp.Place();
        }
    }
        
}
