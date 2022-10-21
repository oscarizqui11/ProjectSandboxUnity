using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    private static int nextScene = 1;

    public static void SetNextScene(int newScene)
    {
        nextScene = newScene;
    }

    public static int GetNextScene()
    {
        return nextScene;
    }

}
