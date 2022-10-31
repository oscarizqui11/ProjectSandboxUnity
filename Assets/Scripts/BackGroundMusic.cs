using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public string musicName;
    public bool isLoop;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.ResetSound();
        SoundManager.Instance.Play(musicName, isLoop);
    }
}
