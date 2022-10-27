using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject gameCanvasUI;
    //public AudioSource _mainMusic;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameOver.Instance.IsGameOver())
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameCanvasUI.SetActive(false);
        Time.timeScale = 0.0f;
        gameIsPaused = true;
        //_mainMusic.spatialBlend = 0.86f;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameCanvasUI.SetActive(true);
        Time.timeScale = 1.0f;
        gameIsPaused = false;
        //_mainMusic.spatialBlend = 0;
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
