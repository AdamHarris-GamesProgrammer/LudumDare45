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

    public void PlaceItem()
    {
        if (lumbermill.isOn)
        {
            lp.Place();
        } 
        else if (mine.isOn)
        {
            mp.Place();
        }
        else if (powerStation.isOn)
        {
            psp.Place();
        }
        else if (oilRefinery.isOn)
        {
            orp.Place();
        }
        else if (factory.isOn)
        {
            fp.Place();
        }
        else if (skyscraper.isOn)
        {
            sp.Place();
        }
    }
}
