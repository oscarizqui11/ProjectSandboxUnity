using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject gameCanvasUI;

    private static GameOver _instance;
    public static GameOver Instance => _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    public void ThrowGameOver()
    {
        gameOverScreen.SetActive(true);
        gameCanvasUI.SetActive(false);
        Time.timeScale = 0.0f;
        isGameOver = true;
        //_mainMusic.spatialBlend = 0.86f;
    }

    public void ReloadScene()
    {
        Time.timeScale = 1.0f;
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}
