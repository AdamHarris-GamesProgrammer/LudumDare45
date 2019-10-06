//libraries
using UnityEngine;
using UnityEngine.SceneManagement;

//gives the option to skip the credits
public class CreditsSkip : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //when user presses any button the game returns to menu
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Isaac_TestLevel");
        }
    }
}
