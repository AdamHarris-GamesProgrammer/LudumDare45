using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepAnimationManager : MonoBehaviour
{
    //represents the gameobobject for the 'Z's in the main menu Earth's sleep animation
    public GameObject SleepImage;

    public float animationTimer = 0.0f;

    //used to check if animation cycle has been completed to avoid copies
    public bool SleepImage1Init = false;
    public bool SleepImage2Init = false;
    public bool SleepImage3Init = false;

    // Update is called once per frame
    void Update()
    {
        animationTimer += 0.1f;
        //checks how many images are in the Sleep animation
        for (int SleepImageCounter = 0; SleepImageCounter < 3; SleepImageCounter++)
        {
            if (animationTimer >= 12.0f && animationTimer < 24.0f && SleepImage1Init == false)
            {
                Instantiate(SleepImage, new Vector2(-100, 0), Quaternion.identity);
                SleepImage1Init = true;
            }
            else if (animationTimer >= 24.0f && animationTimer < 36.0f && SleepImage2Init == false)
            {
                Instantiate(SleepImage, new Vector2(-100, 0), Quaternion.identity);
                SleepImage2Init = true;
            }
            else if (animationTimer >= 36.0f && animationTimer < 48.0f && SleepImage3Init == false)
            {
                Instantiate(SleepImage, new Vector2(-100, 0), Quaternion.identity);
                SleepImage3Init = true;
            }
            else if (animationTimer >= 48.0f)
            {
                animationTimer = 0.0f;

                SleepImage1Init = false;
                SleepImage2Init = false;
                SleepImage3Init = false;
            }
        }
    }
}
