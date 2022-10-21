using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingBehaviour : MonoBehaviour
{
    public int startedFrame;
    public int loadingFrames;

    // Start is called before the first frame update
    void Start()
    {
        startedFrame = Time.frameCount;


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - startedFrame > loadingFrames)
        {
            SceneManager.LoadScene(GameManager.GetNextScene());
        }
    }
}
