using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button creditsButton;
    public Button exitButton;
    public Button backToMainMenuButton;
    
    public GameObject creditsCanvas;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(CreditsMenu);
        backToMainMenuButton.onClick.AddListener(BackMainMenu);
    }
    
    public void PlayGame()
    {
       SceneManager.LoadScene("PinballGame");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsMenu()
    {
        creditsCanvas.SetActive(true);
    }

    public void BackMainMenu()
    {
        creditsCanvas.SetActive(false);
    }
}
