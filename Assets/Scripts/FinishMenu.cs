using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishMenu : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public Color32 winColor;

    public GameObject nextLevelButton;
    public GameObject retryLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ThrowWinPanel(int levelPunctuation)
    {
        GameOver.Instance.SetGameOver(true);

        if(levelPunctuation > 0)
        {
            winText.text = "YOU WIN !";
            winText.faceColor = winColor;

            retryLevelButton.SetActive(false);
            nextLevelButton.SetActive(true);
        }
        else
        {
            winText.text = "TRY AGAIN . . .";

            retryLevelButton.SetActive(true);
            nextLevelButton.SetActive(false);
        }
    }

    public void ReloadScene()
    {
        Time.timeScale = 1.0f;
        GameOver.Instance.SetGameOver(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
