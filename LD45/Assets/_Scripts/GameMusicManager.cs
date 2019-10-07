using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicManager : MonoBehaviour
{

    public AudioSource HappyMusic1;
    public AudioSource HappyMusic2;
    public AudioSource MehMusic;
    public AudioSource SadMusic1;
    public AudioSource SadMusic2;

    bool song1played = false;
    bool song2played = false;
    bool song3played = false;
    bool song4played = false;
    bool song5played = false;

    //each building placed should +1 a integer
    public int tempCounter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if building count is less then 5 and song has not been played before then set to true and play
        if (tempCounter < 5 && song1played == false) {
            song1played = true;
            HappyMusic1.Play();
        }
        if (tempCounter >= 5 && tempCounter < 10 && song2played == false)
        {
            song2played = true;
            HappyMusic1.Stop();
            HappyMusic2.Play();
        }
        if (tempCounter >= 10 && tempCounter < 14 && song3played == false)
        {
            song3played = true;
            HappyMusic2.Stop();
            MehMusic.Play();
        }
        if (tempCounter >= 14 && tempCounter < 18 && song4played == false)
        {
            song4played = true;
            MehMusic.Stop();
            SadMusic1.Play();
        }
        if (tempCounter == 18 && song5played == false)
        {
            song5played = true;
            SadMusic1.Stop();
            SadMusic2.Play();
        }
    }
}
