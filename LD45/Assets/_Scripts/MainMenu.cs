//libraries
using UnityEngine;
using UnityEngine.SceneManagement;

//class for button actions in the main menu user interface
public class MainMenu : MonoBehaviour
{
    //represents the button objects in the main menu
    public GameObject PlayButton;
    public GameObject HelpButton;
    public GameObject QuitButton;
    public GameObject HelpMenu;
    public GameObject HelpMenuExitButton;

    //represents the audio source for the UI buttons
    public AudioSource UI_Button;

    //plays the game scene when the play button is pressed
    public void PlayButtonPressed()
    {
        UI_Button.Play(0);
        SceneManager.LoadScene("Game");
    }

    //quits the game when the quit button is pressed
    public void QuitButtonPressed()
    {
        UI_Button.Play(0);
        Application.Quit();
    }

    public void ButtonHover()
    {

    }

    //displays the help menu when the help button is pressed
    public void HelpButtonPressed()
    {
        UI_Button.Play(0);
        HelpMenu.SetActive(true);
    }

    //exits the help menu when the exit help button is pressed
    public void HelpMenuExitPressed()
    {
        UI_Button.Play(0);
        HelpMenu.SetActive(false);
    }

}

