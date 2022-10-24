using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingBehaviour : MonoBehaviour
{
    private int startedFrame;
    public int loadingFrames;

    // Start is called before the first frame update
    void Start()
    {
        GC.Collect();
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

    static void LogMemory()
    {
        long reservada;
        reservada = GC.GetTotalMemory(false);
        Debug.Log(reservada);
    }
}
