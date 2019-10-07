using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthHeathManager : MonoBehaviour
{
    //global variable of how many building bought
    //each building placed should +1 a integer
    public int tempCounter;

    public GameObject EarthSprite;
    public GameObject EarthFaceSprite;

    public Sprite Earth1;
    public Sprite Earth1Face;
    public Sprite Earth2;
    public Sprite Earth2Face;
    public Sprite Earth3;
    public Sprite Earth3Face;
    public Sprite Earth4;
    public Sprite Earth4Face;
    public Sprite Earth5;
    public Sprite Earth5Face;

    // Update is called once per frame
    void Update()
    {
        //if building count is less then 5 and song has not been played before then set to true and play
        
        if (tempCounter >= 5 && tempCounter < 8)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth1;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth1Face;
        }
        if (tempCounter >= 12 && tempCounter < 14)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth2;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth2Face;
        }
        if (tempCounter >= 14 && tempCounter < 16)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth3;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth3Face;
        }
        if (tempCounter >= 16 && tempCounter < 18)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth4;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth4Face;
        }
        if (tempCounter == 18)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth5;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth5Face;
        }
    }
}
