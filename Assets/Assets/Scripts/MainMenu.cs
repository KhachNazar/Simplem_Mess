using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    GameObject mainMenu;

    [SerializeField]
    GameObject hostMenu;

    [SerializeField]
    GameObject joinMenu;

    [SerializeField]
    GameObject creditsMenu;

    public static bool IsOn = true;

    public void GoToHostMenu ()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        hostMenu.SetActive(!hostMenu.activeSelf);
        HostMenu.IsOn = hostMenu.activeSelf;
    }

    public void GoBackFromHostMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        hostMenu.SetActive(!hostMenu.activeSelf);
        HostMenu.IsOn = hostMenu.activeSelf;
    }

    public void GoToJoinMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        joinMenu.SetActive(!joinMenu.activeSelf);
        JoinMenu.IsOn = joinMenu.activeSelf;
    }

    public void GoBackFromJoinMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        joinMenu.SetActive(!joinMenu.activeSelf);
        JoinMenu.IsOn = joinMenu.activeSelf;
    }

    public void GoToCreditsMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        creditsMenu.SetActive(!creditsMenu.activeSelf);
        CreditsMenu.IsOn = creditsMenu.activeSelf;
    }

    public void GoBackFromCreditsMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        MainMenu.IsOn = mainMenu.activeSelf;
        creditsMenu.SetActive(!creditsMenu.activeSelf);
        CreditsMenu.IsOn = creditsMenu.activeSelf;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
