using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepAnimation : MonoBehaviour
{
    public GameObject SleepImage;
    public GameObject Parent;

    public float animationTimer = 0.0f;

    public float speed = 15f;

    // Update is called once per frame
    void Update()
    {
        animationTimer += 0.1f;
        if (animationTimer >= 36.0f)
        {
            Destroy(gameObject);
        }

        SleepImage.transform.Translate(Vector3.up * (Time.deltaTime / speed));
        SleepImage.transform.Translate(Vector3.left * (Time.deltaTime / speed));
        SleepImage.transform.localScale += new Vector3(0.007f, 0.007f, 0.007f);
    }

    void Start()
    {
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        GameObject Parent = GameObject.Find("Sleep_Animation_Manager_Object");
        gameObject.transform.SetParent(Parent.transform, false);
    }
}
