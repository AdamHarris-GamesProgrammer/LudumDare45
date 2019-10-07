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

    //represents the kaching audio for the UI when you buy something
    public AudioSource BuySound;

    public void PlaceItem()
    {
        if (lumbermill.isOn)
        {
            BuySound.Play();
            lp.Place();
        } 
        else if (mine.isOn)
        {
            BuySound.Play();
            mp.Place();
        }
        else if (powerStation.isOn)
        {
            BuySound.Play();
            psp.Place();
        }
        else if (oilRefinery.isOn)
        {
            BuySound.Play();
            orp.Place();
        }
        else if (factory.isOn)
        {
            BuySound.Play();
            fp.Place();
        }
        else if (skyscraper.isOn)
        {
            BuySound.Play();
            sp.Place();
        }
    }

    //update
        //if lumbermill.isOn
            //set requirments active

        //else 
            //set requirments off
        
}
