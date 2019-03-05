using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public GameObject optionsMenu;
    
    public void PlayTrigger()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsTrigger()
    {
        gameObject.SetActive(false);
        optionsMenu.SetActive(true);
    }
    
    public void OptionsBackTrigger()
    {
        optionsMenu.SetActive(false);
        gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        FindObjectOfType<playerMovement>().gamePaused = false;
        gameObject.SetActive(false);
    }
}
