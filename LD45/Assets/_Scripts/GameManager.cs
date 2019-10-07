using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
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

    public static GameManager instance;

    public int buildingCounter = 0;

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

        HappyMusic1.Play();

    }

    private void Update()
    {
        //if building count is less then 5 and song has not been played before then set to true and play

        if (buildingCounter >= 5 && buildingCounter < 8 && !song1played)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth1;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth1Face;
            song1played = true;
            HappyMusic1.Play();
        }
        if (buildingCounter >= 12 && buildingCounter < 14 && !song2played)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth2;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth2Face;
            song2played = true;
            HappyMusic1.Stop();
            HappyMusic2.Play();
        }
        if (buildingCounter >= 14 && buildingCounter < 16 && !song3played)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth3;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth3Face;
            song3played = true;
            HappyMusic2.Stop();
            MehMusic.Play();
        }
        if (buildingCounter >= 16 && buildingCounter < 18 && !song4played)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth4;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth4Face;
            song4played = true;
            MehMusic.Stop();
            SadMusic1.Play();
        }
        if (buildingCounter == 18 && !song5played)
        {
            EarthSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth5;
            EarthFaceSprite.gameObject.GetComponent<SpriteRenderer>().sprite = Earth5Face;
            song5played = true;
            SadMusic1.Stop();
            SadMusic2.Play();
        }
        if(buildingCounter == 23)
        {
            SceneManager.LoadScene("Credits");
        }

    }


}
